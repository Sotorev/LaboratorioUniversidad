<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UniversityManagement._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ingreso de notas</h1>
        <span style="font-size: large">Universidad</span>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Mesoamericana</asp:ListItem>
            <asp:ListItem>Landivar</asp:ListItem>
            <asp:ListItem>USAC</asp:ListItem>
        </asp:DropDownList>
        <br />

        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <br />
        <div>
            Carne&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Nombre
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Apellido
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
        <br />
        <br />
        <div style="background-color:darkgray; border-radius:25px; padding: 10px">
            Notas
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            Nombre del curso<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ingresar nota" />
        </div>
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Ingresar alumno" />

        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Registrar Universidad" />

    </div>

</asp:Content>
