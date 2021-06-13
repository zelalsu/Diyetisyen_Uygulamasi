using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetisyenUygulamasi.Functions
{
    public class TxtBoxKisitlama
    {
        public void onlyIntValue(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//hastaTcsi arama kısmında sadece int değer girilmesini sağlar
        }
    }
}
