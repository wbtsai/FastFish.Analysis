<%@ Page Title="" Language="C#" EnableEventValidation="false" EnableViewState="false" MasterPageFile="~/Prototype.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FF.ProtoTypeWeb.Index" %>
<%@ Register src="UserControl/DynamicBrickUserControl.ascx" tagname="DynamicBrickUserControl" tagprefix="uc1" %>
<%@ Register src="UserControl/PTUserControl.ascx" tagname="PTUserControl" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        

        
        <uc2:PTUserControl ID="PTUserControl1" StateName="Start" State="Default" runat="server" />
        

        
    </div>
</asp:Content>
