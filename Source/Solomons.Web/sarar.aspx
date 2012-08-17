<%@ Register src="UserControls/menu.ascx" tagname="menu" tagprefix="uc1" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sarar.aspx.cs" Inherits="Solomons.Web.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"><html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"><title>Sarar</title>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<link rel="stylesheet" href="layout.css" type="text/css"/><script language="javascript" type="text/javascript" src="Scripts/jquery-1.4.1.min.js"></script>
    <script src="jquery.innerfade.js" type="text/javascript"></script>
<script language="javascript" type="text/javascript" src="menu.js"></script><style type="text/css">
.auto-style1 {
	font-size: x-large;
}
</style></head><body><form id="form1" runat="server">
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
<div style="text-align: center; font-family: Copperplate Gothic Bold;text-transform: capitalize;font-size:large;margin-top:10px;">
    <img src="images/dyi.png" alt="Defining Your Image" width="180"/><br />    </div>

<br /><br /><span class="auto-style1">
	<strong>W</strong></span><span style="font-size:11.5pt">elcome to Solomon’s 
	where defining your image takes on a life of its own. We take pride in 
	addressing your formal wear needs with the utmost attention to detail and 
	customer service.
<br /><br />
Join our many customers who have been outfitted at our store at The Falls at West Mall and become part of a group of the most elite dressers in the Caribbean. 
	<br />
	<br />
	With our two exclusive brands, Sarar and Hugo Boss, we are confident that your image will be defined in the most elegant manner.</span>
</div>
<div id="middleleft" style="color:#231813;background: transparent url('images/sararbg.jpg') no-repeat;overflow:hidden">

<div id="slideshow" style="z-index: 0; overflow: hidden;">
<img src="images/sararstill1.png" alt="model"  style="position:relative; left:109px; top:-130px;" />
</div><%--
<div style="float:left;margin-top:-560px;margin-left:650px;width:200px;" > <img src="images/sararlg.png" alt="sarar"/> </div>
<div style="float:right;margin-top:-525px;margin-right:125px;width:200px;"> <img src="images/hugobosslg.png" alt="Hugo Boss"/> </div>--%>
 </div>
 </div>

</div>
<div id="menu" style="margin-top:-32px" >


    <uc1:menu ID="menu1" runat="server" />


</div>
<div id="footer" style="color:#83543c;text-align:center;vertical-align:text-bottom; font-size:small;font-family:Verdana, Geneva, Tahoma, sans-serif;height:150px;">
	<div style="margin-top:40px;width:1360px;">
		Copyright &copy; 2012 Solomon's Designs. All rights reserved.
	eserved.
	</div>
</div>
    </form>
</body>
</html>
