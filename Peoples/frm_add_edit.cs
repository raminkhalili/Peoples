using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peoples
{
    public partial class frm_add_edit : Form
    {
        DataBaseDataContext db;
        public frm_add_edit()
        {
            InitializeComponent();
            if(db==null)
                db = new DataBaseDataContext();
        }
        public int id = 0;
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (this.Text == "افزودن")
            {
                db.tbl_persons.InsertOnSubmit(new tbl_person()
                {
                    firstname=txt_firstname.Text,
                    lastname=txt_lastname.Text,
                    phonenumber=txt_phonenumber.Text,
                    description=txt_description.Text,
                    datetime=DateTime.Now
                });
                db.SubmitChanges();
            }
            else if (this.Text == "ویرایش")
            {
                var result = (from person in db.tbl_persons
                             where person.Id == id
                             select person).Single();
                result.firstname = txt_firstname.Text;
                result.lastname = txt_lastname.Text;
                result.phonenumber = txt_phonenumber.Text;
                result.description = txt_description.Text;
                
                db.SubmitChanges();
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
