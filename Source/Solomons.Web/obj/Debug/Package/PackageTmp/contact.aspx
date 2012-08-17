<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="Solomons.Web.contact" %>

<%@ Register src="UserControls/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact Us</title>
    <meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<link rel="stylesheet" href="layout.css" type="text/css"/>
<script language="javascript" type="text/javascript" src="Scripts/jquery-1.4.1.min.js"></script> 
    <script src="jquery.innerfade.js" type="text/javascript"></script>
<script language="javascript" type="text/javascript" src="menu.js"></script> 

<style type="text/css">
.auto-style1 {
	font-size: x-large;
}
    .style8
    {
        width: 100%;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
   <div id="topbar"> </div>
<div id="middle">
<div style="width:1640px;">
<div id="logo" style="float:left;margin-top:-25px;margin-left:10px;font-family:'Myriad Pro';font-size:10pt;" >

	<br />
	<br />
	<br />
	<br />
	<br />
	<br />
	<br />

	<br />
 <div style="text-align: center; font-family: Copperplate Gothic Light;text-transform: capitalize;font-size:large; font-weight:bold;margin-top:10px;">
     <img src="images/dyi.png" alt="Defining Your Image" width="180"/><br />    </div>
    <br/><br/>
<span style="font-size: medium;font-family:verdana">Come and visit us today. </span>
<br/><br/>
<span style="font-size: 11.5pt">
We are located on the upper level (western end) in The Falls at West Mall, Westmoorings, Trinidad.<br/><br/>
Tel: (+) 868 632 8972<br/>Fax: (+) 868 633 9360<br/>E-mail: info@solomonstt.com<br/>
</span>
    <table class="style8">
        <tr>
            <td>
                Name</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="143px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Email</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" Width="143px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Subject</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" Width="143px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Message</td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server" Height="80px" TextMode="MultiLine" 
                    Width="172px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:ImageButton ID="ImageButton1" runat="server" 
                    ImageUrl="~/images/1341191468_Forward.png" onclick="ImageButton1_Click" 
                    Width="25px" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</div>
<div id="middleleft" style="color:#231813;background: transparent url('images/contactbg.jpg') no-repeat;overflow:hidden"> 
<%--<div id="slideshow" >
<img src="images/fpr01.png" alt="model"  style="position:relative; left:189px; top:0px; display:none;" />
<img src="images/fpr02.png" alt="model"  style="position:relative; left:189px; top:0px;"  />
<img src="images/fpr03.png" alt="model"  style="position:relative; left:189px; top:0px; display:none;"/>
<img src="images/fpr04.png" alt="model"  style="position:relative; left:189px; top:0px; display:none;" />
<img src="images/fpr05.png" alt="model" style="position:relative; left:189px; top:0px; display:none;" />
</div>--%>

<div style="float:left;margin-top:-560px;margin-left:650px;width:200px;display:none;" > <img src="images/sararlg.png" alt="sarar"/> </div>
<div style="float:right;margin-top:-525px;margin-right:125px;width:200px;display:none;"> <img src="images/hugobosslg.png" alt="Hugo Boss"/> </div>
</div>
</div>

</div>
<div id="menu" style="margin-top:-32px" >


    <uc1:menu ID="menu1" runat="server" />


</div>
<div id="footer" style="color:#83543c;text-align:center;vertical-align:text-bottom; font-size:small;font-family:Verdana, Geneva, Tahoma, sans-serif;height:150px;">
	<div style="margin-top:40px;width:1360px;">
		Copyright &copy; 2012 Solomon's Designs. All rights reserved.
	</div>
</div>
    </form>
</body>
</html>
