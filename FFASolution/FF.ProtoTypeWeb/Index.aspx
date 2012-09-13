<%@ Page Title="" Language="C#" EnableEventValidation="false" EnableViewState="false" MasterPageFile="~/Prototype.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FF.ProtoTypeWeb.Index" %>
<%@ Register src="UserControl/DynamicBrickUserControl.ascx" tagname="DynamicBrickUserControl" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <uc1:DynamicBrickUserControl ID="DynamicBrickUserControl1" runat="server" />
<hr />
        <uc1:DynamicBrickUserControl ID="DynamicBrickUserControl2" runat="server" />
    </div>
</asp:Content>
