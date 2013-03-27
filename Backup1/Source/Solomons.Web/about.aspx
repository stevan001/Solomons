<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="about.aspx.cs" Inherits="Solomons.Web.about" %>

<%@ Register src="UserControls/menu.ascx" tagname="menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>About Us </title>
    <meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<link rel="stylesheet" href="layout.css" type="text/css"/>
<script language="javascript" type="text/javascript" src="Scripts/jquery-1.4.1.min.js"></script> 
    <script src="jquery.innerfade.js" type="text/javascript"></script>
        <script src="jquery.innerfade.js" type="text/javascript"></script>
<script language="javascript" type="text/javascript" src="menu.js"></script> 

<style type="text/css">
.auto-style1 {
	font-size: 10pt;
	
}
    .style1
    {
        font-size: x-large;
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
 <div style="text-align: center; font-family: Copperplate Gothic Bold;text-transform: capitalize;font-size:large;margin-top:10px;"><img src="images/dyi.png" alt="Defining Your Image" style="width:180px;"/><br />
    </div><br/>

    <span >
    <span class="style1">
    <strong>S</strong></span><span class="auto-style1">olomon’s is located on the upper level in The Falls at West Mall, Trinidad. The store features high-end men’s clothing from their two (2) exclusive brands Hugo Boss and Sarar. The owner Abraham Hadeed takes pride in defining your image and welcomes you to view the current season’s collections.
    <br />
    <br />
    The store opened its doors in 2003 and has clients from all walks of life, including businessmen, professionals, government officials and just about anyone who is serious about dressing.<br />
    <br />
    Our highly trained and courteous staff will ensure that you make the right choice of wear for that special occasion or event.
    <br />
    <br />
    The owner, with his 30 years of experience in the business, is always happy to assist in making sure that you get the best fit, with particular attention to style and color. The best sartorial artist in the country handles all our adjustments in-house.
    <br />
    <br />
   

</span>
</span>
</div>
<div id="middleleft" style="color:#231813;background: transparent url('images/aboutbg.jpg') no-repeat;overflow:hidden"> 
<%--<div id="slideshow">
<img src="images/fpr01.png" alt="model"  style="position:relative; left:189px; top:0px; display:none;" />
<img src="images/fpr02.png" alt="model"  style="position:relative; left:189px; top:0px;"  />
<img src="images/fpr03.png" alt="model"  style="position:relative; left:189px; top:0px; display:none;"/>
<img src="images/fpr04.png" alt="model"  style="position:relative; left:189px; top:0px; display:none;" />
<img src="images/fpr05.png" alt="model" style="position:relative; left:189px; top:0px; display:none;" />
</div><div style="float:left;margin-top:-560px;margin-left:650px;width:200px;" > <img src="images/sararlg.png" alt="sarar"/> </div>
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
	</div>
</div>
    </form>
</body>
</html>
