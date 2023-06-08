using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BabyCarrot.Tools
{
    public enum LogType { Daliy, Monthly }
    public class LogManager
    {
        private string _path;


        #region < Constructors >
        public LogManager(string  path, LogType logType, string prefix, string postfix)
        {
            _path = path;
            _SetLogPath(logType, prefix, postfix);
        }

        public LogManager(string prefix, string postfix)
            : this(Path.Combine(Application.Root, "Log"), LogType.Daliy, prefix, postfix)
        {

        }

        public LogManager()
            : this(Path.Combine(Application.Root, "Log"), LogType.Daliy, null, null)
        {
        }
        #endregion

        #region < Methods >
        private void _SetLogPath(LogType logType, string prefix, string postfix)
        {
            string path = String.Empty;
            string name = String.Empty;

            switch (logType)
            {
                case LogType.Daliy:
                    path = String.Format(@"{0}\{1}\", DateTime.Now.Year, DateTime.Now.ToString("MM"));
                    name = DateTime.Now.ToString("yyyyMMdd");
                    break;

                case LogType.Monthly:
                    path = String.Format(@"{0}\", DateTime.Now.Year);
                    name = DateTime.Now.ToString("yyyyMM");
                    break;
            }

            _path = Path.Combine(_path, path);

            if (!Directory.Exists(_path)) // 경로가 존재하지 않으면 만들어주라
            {
                Directory.CreateDirectory(_path);
            }

            if (String.IsNullOrEmpty(prefix))
            {
                name = prefix + name;
            }
            if (String.IsNullOrEmpty(postfix))
            {
                name = postfix + name;
            }
            name += ".txt";
            _path = Path.Combine(_path, name);
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
