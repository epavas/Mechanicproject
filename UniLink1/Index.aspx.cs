using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
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
                nombre.Text = Session["Usuario"].ToString() + " " + Session["Apellido"].ToString();
                carrera.Text = Session["Carrera"].ToString();
                dt.Columns.Add("Codigo");
                dt.Columns.Add("Empresa");
                dt.Columns.Add("Nombre Contacto");
                dt.Columns.Add("Tel Contacto");
                dt.Columns.Add("Descripcion");
                dt.Columns.Add("Carrera");
                dt.Columns.Add("Salario");
                String[] datos = bd.ofertas("Oferta", "Carrera", carrera.Text);
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

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Perfil.aspx");
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("Default.aspx");
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        
    }

    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("Empleos.aspx");
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int f = GridView1.SelectedIndex;
        String a = GridView1.Rows[f].Cells[3].Text;
        /*Label1.Text = a;*/
    }

    protected void LinkButton2_Click1(object sender, EventArgs e)
    {
        Response.Redirect("SubirOferta.aspx");
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Amigos.aspx");
    }
}