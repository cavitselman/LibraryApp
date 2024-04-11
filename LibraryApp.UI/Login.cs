using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace LibraryApp.UI
{
    public partial class Login : Form
    {
        FormBooks formBooks;
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("server=.\\SQLEXPRESS;Initial Catalog=LibraryApp;Integrated Security=True;TrustServerCertificate=True;");
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string sifre = "";

            if ((textBoxKullaniciAdi.Text == "") || (textBoxSifre.Text == ""))
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre hatalı !");
                return;
            }


            try
            {
                baglanti.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT Password FROM LibraryManagers WHERE UserName = @p1", baglanti);
                sqlKomut.Parameters.AddWithValue("@p1", textBoxKullaniciAdi.Text);
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    sifre = sqlDataReader[0].ToString();
                }
                //label3.Text = sifre;

                if (sifre == textBoxSifre.Text)
                {
                    formBooks = new FormBooks();
                    this.Hide();
                    formBooks.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı !");
                    textBoxKullaniciAdi.Text = "";
                    textBoxSifre.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası!" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }      
        private void textBoxSifre_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonGiris_Click(this, new EventArgs());
            }
        }
        private void textBoxKullaniciAdi_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonGiris_Click(this, new EventArgs());
            }
        }
    }

}
