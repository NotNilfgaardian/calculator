using Model;
using System.Collections;
using System.IO;

namespace Presenter
{
    public class InitialPresenter
    {
        private readonly IDataService service = new DataService();
        public bool TextDataIni(string text)
        {
            string[] strNumber = text.Trim().Split(' ');
            ArrayList list = new ArrayList();
            for (int j = 0; j < strNumber.Length; j++)
            {
                if (!double.TryParse(strNumber[j], out var number))
                {
                  return false;
                }
                list.Add(number);
            }
            service.AddList(list);
            return true;
        }

        public string FileDataIni(string path)
        {
            string text;
            try
            {
                using (StreamReader reader = File.OpenText(path))
                {
                   text = reader.ReadToEnd();
                }
            }
            catch (System.Exception)
            {
                return "ERROR";
            }
            return text;
        }
    }
}
