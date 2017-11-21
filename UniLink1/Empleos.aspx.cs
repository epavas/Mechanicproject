using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Empleos : System.Web.UI.Page
{
    DataTable dt = new DataTable();
    Mongodb bd = new Mongodb();
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
                RadioButton2.Checked = true;
                RadioButton1.Text = "Empresa";
                RadioButton2.Text = "Descripcion";
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

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("Index.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            String[] datos;
            if (TextBox2.Text == "")
            {
                mensaje("Asegurese de llenar todos los campos");
            }
            else
            {
                dt.Columns.Add("Codigo");
                dt.Columns.Add("Empresa");
                dt.Columns.Add("Nombre Contacto");
                dt.Columns.Add("Tel Contacto");
                dt.Columns.Add("Descripcion");
                dt.Columns.Add("Carrera");
                dt.Columns.Add("Salario");
                if (RadioButton1.Checked == true)
                {
                    datos = bd.trabajos("Oferta", "Empresa", TextBox2.Text);
                }
                else
                {
                    datos = bd.trabajos("Oferta", "Descripcion", TextBox2.Text);
                    mensaje("cambio 2");
                }

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
                GridView1.DataBind();
            }
        }
        catch (Exception)
        {

            throw;
        }

    }
    public void mensaje(String mensaje)
    {
        string script = "alert(\"" + mensaje + "\");";
        ScriptManager.RegisterStartupScript(this, GetType(),
                              "ServerControlScript", script, true);
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = dt;
        GridView1.DataBind();

    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Amigos.aspx");
    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton2.Checked = false;
        RadioButton1.Checked = true;
    }

    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton1.Checked = false;
        RadioButton2.Checked = true;
    }
}