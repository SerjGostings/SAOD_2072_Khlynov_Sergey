using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Связный_список
{
    class MyList
    {
        Node BegList;

        public MyList()
        {
            BegList = null;
        }
        public bool AddToBegin(MyData data)
        {

            BegList = new Node(data, BegList);
            return true;

        }
        public bool AddToEnd(MyData DataObj)
        {
            if (BegList == null)
            {
                AddToBegin(DataObj);
                return true;
            }

            Node ObjLink = new Node();
            ObjLink.Data = DataObj;
            Node PCur;
            PCur = BegList;
            while (PCur.Next != null)
            {
                PCur = PCur.Next;
            }
            PCur.Next = ObjLink;

            return true;
        }
        public MyData Search(int key)
        {
            Node Pcur;
            Pcur = BegList;
            while (Pcur != null)
            {
                if (Pcur.Data.numb == key)
                {
                    return Pcur.Data;
                }

                Pcur = Pcur.Next;
            }

            return null;

        }
        public bool AddToOrderList(MyData data)
        {
            Node Pcur = BegList;
            if (BegList == null)
            {
                BegList = new Node(data);
                return true;
            }
            while (Pcur != null)
            {
                if (Pcur.Data.numb> data.numb)
                {
                    Pcur.Next = new Node(Pcur.Data, Pcur.Next);
                    Pcur.Data = data;
                    return true;
                }
                if (Pcur.Next == null)
                {
                    break;
                }
                Pcur = Pcur.Next;
            }
            Pcur.Next = new Node(data);
            return true;
        }
        public bool Delete(int key)
        {

            Node Pcur = BegList;
            if (Pcur == null) return false;
            if (BegList.Data.numb== key)
            {
                BegList = BegList.Next;
                return true;
            }
            if (Pcur.Next == null)
            {
                return false;
            }
            while (Pcur.Next != null)
            {
                if (Pcur.Next.Data.numb== key)
                {
                    Pcur.Next = Pcur.Next.Next;
                    break;
                }
                Pcur = Pcur.Next;
            }
            return false;
        }

        public void Visual(ListBox list_box)
        {
            list_box.Items.Clear();
            Node Pcur = BegList;
            while (Pcur != null)
            {
                list_box.Items.Add($"Номер задания: {Pcur.Data.numb}, Название: {Pcur.Data.name}, Сдано ли?: {Pcur.Data.trueorfalse}");
                Pcur = Pcur.Next;
            }

        }
    }
}
