<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
<img id="imageToSwap" src="images/a.jpg" />

<br/><br/>

<select id="dlist" onchange="swapImage()">
    <option value="images/a.jpg">a</option>
<option value="images/b.jpg" >b</option>
<option value="images/c.jpg">c</option>
</select>

<script type="text/javascript">
    function swapImage() {
        var image = document.getElementById("imageToSwap");
        var dropd = document.getElementById("dlist");
        image.src = dropd.value;
    };
</script>
    </div>
    </form>
</body>
</html>
