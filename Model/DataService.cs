using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DataService : IDataService
    {

        public void AddList(ArrayList list)
        {
            ArrayList data = DataBase.data;
            data.Add(list);
        }

        public ArrayList GetList(int i)
        {
            ArrayList data = (ArrayList)DataBase.data[i];
            return data;
        }

        public void DeleteLast(int count)
        {
            DataBase.data.RemoveRange(DataBase.data.Count - count, count);
        }


        public void UpdateArgs(int LastOperNum, double n)
        {
            DataBase.LastOperNum = LastOperNum;
            DataBase.n = n;
        }

        public ArrayList GetArgs()
        {
            ArrayList list = new ArrayList();
            list.Add(DataBase.LastOperNum);
            list.Add(DataBase.n);
            return list;
        }

        public ArrayList GoSum(int i, double n)
        {
            ArrayList data = DataBase.data;
            ArrayList list = (ArrayList)data[i];
            ArrayList result = new ArrayList();
            foreach (double number in list)
            {
                result.Add(number + n);
            }
            data.Add(result);
            return result;
        }

        public ArrayList GoSub(int i, double n)
        {
            ArrayList data = DataBase.data;
            ArrayList list = (ArrayList)data[i];
            ArrayList result = new ArrayList();
            foreach (double number in list)
            {
                result.Add(number - n);
            }
            data.Add(result);
            return result;
        }

        public ArrayList GoMult(int i, double n)
        {
            ArrayList data = DataBase.data;
            ArrayList list = (ArrayList)data[i];
            ArrayList result = new ArrayList();
            foreach (double number in list)
            {
                result.Add(number * n);
            }
            data.Add(result);
            return result;
        }

        public ArrayList GoDiv(int i, double n)
        {
            ArrayList data = DataBase.data;
            ArrayList list = (ArrayList)data[i];
            ArrayList result = new ArrayList();
            foreach (double number in list)
            {
                result.Add(number / n);
            }
            data.Add(result);
            return result;
        }

        public ArrayList GoPow(int i, double n)
        {
            ArrayList data = DataBase.data;
            ArrayList list = (ArrayList)data[i];
            ArrayList result = new ArrayList();
            foreach (double number in list)
            {
                result.Add(Math.Pow(number, n));
            }
            data.Add(result);
            return result;
        }

        public ArrayList GoSq(int i, double n)
        {
            ArrayList data = DataBase.data;
            ArrayList list = (ArrayList)data[i];
            ArrayList result = new ArrayList();
            foreach (double number in list)
            {
                if (number < 0) throw new Exception("negative number under root");
                result.Add(Math.Pow(number, 1 / n));
            }
            data.Add(result);
            return result;
        }

        public ArrayList GoLog(int i, double n)
        {
            ArrayList data = DataBase.data;
            ArrayList list = (ArrayList)data[i];
            ArrayList result = new ArrayList();
            foreach (double number in list)
            {
                if (number < 0) throw new Exception("negative number in log");
                result.Add(Math.Log(number) / Math.Log(n));
            }
            data.Add(result);
            return result;
        }

        public ArrayList GoFakt(int i)
        {
            ArrayList data = DataBase.data;
            ArrayList list = (ArrayList)data[i];
            ArrayList result = new ArrayList();
            foreach (double number in list)
            {
                if (number < 0) throw new Exception("negative number");
                double num = Math.Floor(number);
                num = Fakt(num);
                result.Add(num);
            }
            data.Add(result);
            return result;
        }

        public ArrayList GoMed(int index)
        {
            ArrayList data = DataBase.data;
            ArrayList list = new ArrayList();
            list.AddRange((ArrayList)data[index]);
            double temp = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if ((double)list[i] > (double)list[j])
                    {
                        temp = (double)list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            if (list.Count % 2 == 1) temp = (double)list[list.Count / 2];
            else temp = ((double)list[list.Count / 2] + (double)list[list.Count / 2 - 1]) / 2;
            
            ArrayList result = new ArrayList();
            result.Add(temp);
            data.Add(result);
            return result;
        }

        public ArrayList GoDisp(int i)
        {
            ArrayList data = DataBase.data;
            ArrayList list = new ArrayList();
            list.AddRange((ArrayList)data[i]);
            ArrayList result = new ArrayList();
            double temp = 0;
            if (list.Count == 1) result.Add((double)0);
            else
            {
                for (int j = 0; j < list.Count; j++)
                {
                    temp += (double)list[j];
                }
                temp = temp / list.Count;
                for (int j = 0; j < list.Count; j++)
                {
                    list[j] = (double)list[j] - temp;
                    list[j] = (double)list[j] * (double)list[j];
                }
                for (int j = 0; j < list.Count; j++)
                {
                    temp += (double)list[j];
                }
                temp = temp / (list.Count - 1);
                temp = Math.Sqrt(temp);

                result.Add(temp);
            }
            data.Add(result);
            return result;
        }

        private double Fakt(double N)
        {           
                if (N == 0) // если пользователь ввел ноль,
                    return 1; // возвращаем факториал от нуля - не удивляетесь, но это 1 =)
                else // Во всех остальных случаях
                    return N * Fakt(N - 1); // делаем рекурсию.
        }

        public ArrayList GoSum(int i)
        {
            return GoSum(i, DataBase.n);
        }

        public ArrayList GoSub(int i)
        {
            return GoSub(i, DataBase.n);
        }

        public ArrayList GoMult(int i)
        {
            return GoMult(i, DataBase.n);
        }

        public ArrayList GoDiv(int i)
        {
            return GoDiv(i, DataBase.n);
        }

        public ArrayList GoPow(int i)
        {
            return GoPow(i, DataBase.n);
        }

        public ArrayList GoSq(int i)
        {
            return GoSq(i, DataBase.n);
        }

        public ArrayList GoLog(int i)
        {
            return GoLog(i, DataBase.n);
        }

    }
}
