<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="container">
        <h1>Calculator</h1>

        <h4>Enter your numbers and select an operator.</h4>
         <h3><%=Equation %></h3>
        <h3><%=Answer %></h3>
        <br />
        <form id="form1" runat="server">
            <div class="form-group">
                <input type="text" class="form-control" name="Number1" />
                <br />
                <select name="DropDown">
                    <%
                        foreach (var operation in Operators)
                        { %>
                    <option value="<%=operation %>"><%= operation %></option>
                    <% } %>
                </select>
                <h4>Select Your Operator</h4>
                <br />
                <input type="text" class="form-control" name="Number2" />
            </div>
            <div>
                <input type="submit" class="btn btn-primary" value="Submit" />
            </div>
        </form>
    </div>
</body>
</html>
