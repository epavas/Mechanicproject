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
                dt.Columns.Add("Codigo");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Apellido");
                dt.Columns.Add("Correo");
                dt.Columns.Add("Especialidad");
                dt.Columns.Add("Años de experiencia");
                //dt.Columns.Add("Salario");
                String[] datos = bd.Mecanicos();
                for (int i = 0; i < datos.Length; i++)
                {
                    //estamos en los usuarios ahora colocamos cada dato
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
        HttpCookie datos = new HttpCookie("datos");
        datos.Values["Nombre"] = GridView1.Rows[f].Cells[2].Text;
        datos.Values["Apellido"] = GridView1.Rows[f].Cells[3].Text;
        datos.Values["Correo"] = GridView1.Rows[f].Cells[4].Text;
        datos.Values["Carrera"] = GridView1.Rows[f].Cells[5].Text;
        datos.Values["Semestre"] = GridView1.Rows[f].Cells[6].Text;
        Response.Cookies.Add(datos);
        Response.Redirect("Perfil2.aspx");
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