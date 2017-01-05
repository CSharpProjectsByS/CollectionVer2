using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolekcja_nr_2
{
    public partial class Form1 : Form
    {
        private MyCollection<int> collection = new MyCollection<int>(0);

        public Form1()
        {
            InitializeComponent();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(NewValue.Text);
            collection.Add(value);
            showCollection();
        }

        

        private void ClearCollectionButton_Click(object sender, EventArgs e)
        {
            CollectionView.Items.Clear();
        }

        private void ShowCollectionButton_Click(object sender, EventArgs e)
        {
            CollectionView.Items.Clear();
            showCollection();
        }

        private void ValueByIndexShowButton_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(IndexToShowValue.Text);
            String message = "";
            if (index < collection.Count())
            {
                int value = collection[index];
                message = "kolekcja[" + index + "] = " + value;
            }
            else {
                message = "Podany indeks jest nieprawidłowy.";
            }

            showMessageInCollectionView(message);
            
        }


        private void IndeksByValueShowButton_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(ValueToShowIndex.Text);
            int index = collection.IndexOf(value);
            String message = "Wartość: " + value + ", indeks: " + index;
            showMessageInCollectionView(message);
        }

        private void ModifyValueButton_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(IndexToModifyValue.Text);
            int value = Int32.Parse(ValueToModify.Text);

            collection[index] = value;

            showCollection();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RemoveByIndexButton_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(IndexToDeleteValue.Text);
            collection.RemoveAt(index);

            showCollection();
        }

        private void RemoveByValueButton_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(ValueToDeleteElement.Text);
            collection.Remove(value);
            showCollection();
        }

        private void showCollection()
        {
            CollectionView.Items.Clear();
            int i = 0;
            foreach (int element in collection)
            {
                String position = "[" + i + "]: ";
                CollectionView.Items.Add(position + element.ToString());
                i++;
            }
        }

        private void showMessageInCollectionView(String message)
        {
            CollectionView.Items.Clear();
            CollectionView.Items.Add(message);
        }
    }
}
