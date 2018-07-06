<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BackColorPicker.aspx.cs" Inherits="BackColorPicker" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<asp:Content ID="Content4" ContentPlaceHolderID="contentHolder" Runat="Server">
	<asp:TextBox ID="backColorField" runat="server"></asp:TextBox>
	<ajaxToolkit:ColorPickerExtender ID="backColorField_ColorPickerExtender" runat="server" TargetControlID="backColorField" PopupPosition="Right" SampleControlID="preview" />
	<asp:Button ID="selectBtn" runat="server" Text="Set Color" OnClick="selectBtn_Click" />
	<div id="preview"></div>
</asp:Content>

