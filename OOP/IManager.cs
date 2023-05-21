using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IManager
    {
        public void InputList(int size);
        public void OutputList();
        public void SaveFile();
        public void LoadFile();

        public void HigestSalaryList();

        public void MoreThanTenSlotList();

        public void TotalSlot();
        public void SortBySalary();
        public void NameStartWithT();
        public void CoefficientSmallerThanTwo();


    }
}
