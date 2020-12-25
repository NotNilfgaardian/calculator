using Model;
using System;
using System.Collections;
using System.IO;

namespace Presenter
{
    public class MainPresenter
    {
        private readonly IDataService service = new DataService();

        private string Convert(ArrayList list)
        {
            string text = "";
            foreach (double number in list)
            {
                double rounded = Math.Round(number, 4);
                text += rounded.ToString();
                text += " ";
            }
            return text;
        }

        public string GetData(int i)
        {
            ArrayList list = service.GetList(i);
            return Convert(list);
        }

        public bool FileDataExport(string path, int i)
        {
            string text = GetData(i);
            try
            {
                using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    writer.Write(" ");
                    writer.Write(text);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string DoMath(int i, int choice, string strN)
        {
            double n = 0;
            if (strN.Length > 0)
            {
                bool result = double.TryParse(strN, out n);
                if (!result)
                {
                    throw new Exception("Wrong DLC data");
                }
            }
            ArrayList data = Choise(i, choice, n);
            service.UpdateArgs(choice, n);
            return Convert(data);
        }

        public string RepeatMath(int i)
        {
            ArrayList args = service.GetArgs();
            int choice = (int)args[0];
            double n = (double)args[1];
            ArrayList data = Choise(i, choice, n);
            return Convert(data);
        }

        private ArrayList Choise(int i, int choice, double n)
        {
            ArrayList data = new ArrayList();
            switch (choice)
            {
                case 1: data = service.GoSum(i, n); break;
                case 2: data = service.GoSub(i, n); break;
                case 3: data = service.GoMult(i, n); break;
                case 4:
                    {
                        if (n == 0) throw new Exception("Division by ZERO");
                        data = service.GoDiv(i, n);
                        break;
                    }
                case 5: data = service.GoPow(i, 2); break;
                case 6: data = service.GoPow(i, n); break;
                case 7: data = service.GoSq(i, 2); break;
                case 8: data = service.GoSq(i, n); break;
                case 9:
                    {
                        if (n < 0 || n == 1) throw new Exception("error in logalithm base");
                        data = service.GoLog(i, n);
                        break;
                    }
                case 10: data = service.GoFakt(i); break;
                case 11: data = service.GoMed(i); break;
                case 12: data = service.GoDisp(i); break;
                default: break;
            }
            return data;
        }

        public void DeleteLast(int delCount)
        {
            service.DeleteLast(delCount);
        }
    }
}
