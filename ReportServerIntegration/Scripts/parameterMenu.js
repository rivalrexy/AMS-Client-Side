


var jQueryScript = document.createElement('script');  
jQueryScript.setAttribute('src','src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"');
document.head.appendChild(jQueryScript);

   
        debugger;
        $(document).ready(function () {



            $.ajax({
                url: '/api/documentbase',
                method: 'Get',
                dataType: 'json',
                contentType: 'application/json; charset=utf-8',

                success: function (data) {
                    alert("Saved successfully");
                },
                fail: function (jqXHR, textStatus) {
                    alert("Request failed: " + textStatus);
                }
            })
        });
