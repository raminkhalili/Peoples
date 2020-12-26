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
    public partial class frm_view : Form
    {
        public int id = 0;
        DataBaseDataContext db;
        
        public frm_view()
        {
            InitializeComponent();
            if (db == null)
                db = new DataBaseDataContext();


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مایلید این مخاطب حذف شود؟","حذف مخاطب",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var person = (from persons in db.tbl_persons
                              where persons.Id == id
                              select persons).Single();
                db.tbl_persons.DeleteOnSubmit(person);
                db.SubmitChanges();
                DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void frm_view_Load(object sender, EventArgs e)
        {
            var person = (from persons in db.tbl_persons
                          where persons.Id == id
                          select persons).Single();
            lbl_status.Text = person.firstname + " " + person.lastname + "\n" + person.phonenumber + "\n" + Convert.ToDateTime(person.datetime).ToPersianDateString() + "\n" + person.description;
            
        }
    }
}
