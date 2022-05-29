using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Связный_список
{
    class Tree
    {
        LinkTree Root;

        public Tree()
        {
            Root = null;
        }

        public bool Add(MyData data)
        {
            LinkTree PCur = new LinkTree(data);
            if (Root == null) { Root = PCur; return true; }
            return Add(Root, PCur);
        }
        private bool Add(LinkTree Pcur, LinkTree data)
        {

            if (Pcur.Data.numb > data.Data.numb)
            {
                if (Pcur.Left == null)
                {
                    data.Prev = Pcur;
                    Pcur.Left = data;
                    return true;
                }
                Add(Pcur.Left, data);
            }
            if (Pcur.Data.numb < data.Data.numb)
            {
                if (Pcur.Right == null)
                {
                    data.Prev = Pcur;
                    Pcur.Right = data;
                    return true;
                }
                Add(Pcur.Right, data);

            }
            return false;
        }

        public MyData Search(int key)
        {
            if (Root == null) { return null; }
            return Search(Root, key);
        }
        private MyData Search(LinkTree root, int key)
        {
            if (root.Data.numb == key) { return root.Data; }
            if (key < root.Data.numb)
            {
                if (root.Left == null) { return null; }
                return Search(root.Left, key);
            }
            if (key > root.Data.numb)
            {
                if (root.Right == null) { return null; }
                return Search(root.Right, key);
            }
            return null;
        }
        public LinkTree Delete(int key)
        {
            if (Search(key) == null) { return null; }
            return Delete(Root, key);
        }
        private LinkTree Delete(LinkTree root, int key)
        {
            LinkTree Pcur;

            if (root == null) { return root; }     /*если дерева нет*/

            if (key < root.Data.numb) { root.Left = Delete(root.Left, key); }           /*ищем узел*/
            else if (key > root.Data.numb) { root.Right = Delete(root.Right, key); }
            else
            {
                if (root.Left == null && root.Right == null)    /*если лист*/
                {
                    Pcur = root.Prev;
                    if (Pcur.Left == root) { Pcur.Left = null; }
                    else { Pcur.Right = null; }
                    root = null;
                }
                else if (root.Right != null && root.Left != null) /*если ветвление*/
                {
                    LinkTree max = Max(root.Right);
                    root.Data = max.Data;
                    root.Right = Delete(root.Right, max.Data.numb);

                }
                else                                                     /*если передаточный*/
                {
                    LinkTree son;
                    if (root.Left != null) { son = root.Left; }
                    else { son = root.Right; }

                    root = son;
                }
            }



            return root;
        }
        private LinkTree Max(LinkTree elem)
        {
            while (elem.Left != null)
            {
                elem = elem.Left;

            }
            return elem;
        }
        public void Visual(ListBox lb)
        {
            Visual(Root, 1, "", lb);
        }
        private void Visual(LinkTree PSubTree, int level, string space, ListBox lb)
        {
            if (PSubTree == null) return;
            string infNode = space;
            infNode += Convert.ToString(level);
            infNode += " ";
            infNode += PSubTree.Data.numb;
            lb.Items.Add(infNode);

            if (PSubTree.Left != null) { Visual(PSubTree.Left, level + 1, space + " <-", lb); };

            if (PSubTree.Right != null) { Visual(PSubTree.Right, level + 1, space + " ->", lb); };


        }
    }
}
