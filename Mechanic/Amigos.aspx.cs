using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Amigos : System.Web.UI.Page
{
    DataTable dt = new DataTable();
    Mongodb bd = new Mongodb();
    String[] datos;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                RadioButton1.Text = "Nombre";
                RadioButton2.Text = "Apellido";
                RadioButton3.Text = "Carrera";
                RadioButton4.Text = "Semestre";
            }
        }
        catch (Exception)
        {

            throw;
        }

    }

    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("Empleos.aspx");
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {

    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("Default.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (TextBox4.Text == "")
            {
                mensaje("Asegurese de llenar todos los campos");
            }
            else
            {

                if (RadioButton1.Checked)
                {
                    datos = bd.amigos("UserF", "Nombre", TextBox4.Text);
                }
                if (RadioButton2.Checked)
                {
                    datos = bd.amigos("UserF", "Apellido", TextBox4.Text);
                }
                if (RadioButton3.Checked)
                {
                    datos = bd.amigos("UserF", "Carrera", TextBox4.Text);
                }
                if (RadioButton4.Checked)
                {
                    datos = bd.amigos("UserF", "Semestre", TextBox4.Text);
                }
                dt.Columns.Add("Codigo");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Apellido");
                dt.Columns.Add("Correo");
                dt.Columns.Add("Carrera");
                dt.Columns.Add("Semestre");

                for (int i = 0; i < datos.Length; i++)
                {
                    String[] aux = datos[i].Split(',');
                    for (int j = 0; j < aux.Length; j++)
                    {
                        if (j != 0)
                        {
                            aux[j] = (aux[j].Substring(aux[j].LastIndexOf(':') + 2)).Replace("\"", "");
                        }
                        else
                        {
                            aux[j] = aux[j].Replace(")", "");
                            aux[j] = (aux[j].Substring(aux[j].LastIndexOf('(') + 2)).Replace("\"", "");
                        }
                    }
                    dt.Rows.Add(aux);

                }
                GridView1.DataSource = dt;
                /*GridView1.Rows[0].Visible = false;*/
                GridView1.DataBind();
            }
        }
        catch (Exception)
        {

            throw;
        }

    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    public void mensaje(String mensaje)
    {
        string script = "alert(\"" + mensaje + "\");";
        ScriptManager.RegisterStartupScript(this, GetType(),
                              "ServerControlScript", script, true);
    }

    protected void LinkButton4_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Amigos.aspx");
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int f = GridView1.SelectedIndex;
        HttpCookie datos = new HttpCookie("datos");
        datos.Values["Nombre"] = GridView1.Rows[f].Cells[2].Text;
        datos.Values["Apellido"] = GridView1.Rows[f].Cells[3].Text;
        datos.Values["Correo"] = GridView1.Rows[f].Cells[4].Text;
        datos.Values["Carrera"] = GridView1.Rows[f].Cells[5].Text;
        datos.Values["Semestre"] = GridView1.Rows[f].Cells[6].Text;
        Response.Cookies.Add(datos);
        Response.Redirect("Perfil2.aspx");
        /*Label5.Text = GridView1.Rows[f].Cells[5].Text;*/
    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton2.Checked = false;
        RadioButton3.Checked = false;
        RadioButton4.Checked = false;
    }

    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton1.Checked = false;
        RadioButton3.Checked = false;
        RadioButton4.Checked = false;
    }

    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton1.Checked = false;
        RadioButton2.Checked = false;
        RadioButton4.Checked = false;
    }

    protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton1.Checked = false;
        RadioButton2.Checked = false;
        RadioButton3.Checked = false;
    }
}