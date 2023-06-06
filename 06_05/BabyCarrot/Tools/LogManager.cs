using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BabyCarrot.Tools
{
    public class LogManager
    {
        private string _path;


        #region < Constructors >
        public LogManager(String  path)
        {
            _path = path;
            _SetLogPath();
        }

        public LogManager()
            : this(Path.Combine(Application.Root, "Log"))
        {
        }
        #endregion

        #region < Methods >
        private void _SetLogPath()
        {
            if (!Directory.Exists(_path)) // 경로가 존재하지 않으면 만들어주라
            {
                Directory.CreateDirectory(_path);
            }

            string logFile = DateTime.Now.ToString("yyyyMMdd") + ".txt";
            _path = Path.Combine(_path, logFile);
        }

        public void Write(string data)
        {
            try // 로그를 남기는 중에 프로그램이 멈추는 일이 없도록 하기 위해서 try catch를 해준다
            {
                using (StreamWriter writer = new StreamWriter(_path, true))
                // using은 윈도우 리소스를 이용할 때 사용, using 선언으로 생성된 streamwriter라는 객체는 
                // 중괄호 안에서만 유효하고 벗어나면 자동으로 파일이 닫힌다.
                {
                    writer.Write(data); // 기록을 하고 줄바꿈을 하지 않는다.
                }
                // StreamWriter는 이 파일이 없으면 생성을 해주고, 있으면 파일이 있는 경우에는 추가모드로 열어준다.
            }
            catch (Exception ex)
            {

            }
        }

        public void WriteLine(string data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_path, true))
                {
                    writer.WriteLine(DateTime.Now.ToString("yyyyMMdd HH:mm:ss\t") + data);
                }
            }
            catch(Exception ex)
            {

            }
        }
        #endregion
    }
}
