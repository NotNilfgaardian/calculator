using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IDataService
    {
        void AddList(ArrayList list);
        ArrayList GetList(int i);
        void DeleteLast(int i);
        void UpdateArgs(int i, double n);
        ArrayList GetArgs();

        ArrayList GoSum(int i);
        ArrayList GoSub(int i);
        ArrayList GoMult(int i);
        ArrayList GoDiv(int i);
        ArrayList GoPow(int i);
        ArrayList GoSq(int i);
        ArrayList GoLog(int i);

        ArrayList GoSum(int i, double n);
        ArrayList GoSub(int i, double n);
        ArrayList GoMult(int i, double n);
        ArrayList GoDiv(int i, double n);
        ArrayList GoPow(int i, double n);
        ArrayList GoSq(int i, double n);
        ArrayList GoLog(int i, double n);
        ArrayList GoFakt(int i);
        ArrayList GoMed(int index);
        ArrayList GoDisp(int i);
    }
}
