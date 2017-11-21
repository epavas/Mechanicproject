using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SubirOferta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("Default.aspx");
            }
        }
        catch (Exception)
        {

            throw;
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Mongodb bd = new Mongodb();
        try
        {
            BsonDocument documento = new BsonDocument
        {
            {"Empresa", nom.Text },
            {"Nombre Contacto",ncontacto.Text },
            {"Telefono de Contacto",tel.Text },
            {"Descripcion",desc.Text },
            {"Carrera",carrerasop.SelectedItem.ToString() },
            {"Salario",sal.Text },
        };
            bd.insert("Oferta", documento);
            mensaje("Oferta subida con exito");
            nom.Text = "";
            ncontacto.Text = "";
            tel.Text = "";
            desc.Text = "";
            carrerasop.SelectedValue = "1";
            sal.Text = "";
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

    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("Empleos.aspx");
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("Default.aspx");
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Amigos.aspx");
    }
}