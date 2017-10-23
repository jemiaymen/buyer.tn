


$(".alogin").click(function(){
    $("#registerForm").ejDialog("close");
    $("#changepasswordForm").ejDialog("close");
    $("#forgetpasswordForm").ejDialog("close");

    $("#loginForm").ejDialog("open");
});

$(".aregister").click(function(){
    $("#changepasswordForm").ejDialog("close");
    $("#loginForm").ejDialog("close");
    $("#forgetpasswordForm").ejDialog("close");

    $("#registerForm").ejDialog("open");
});


$(".aforget").click(function(){
    $("#registerForm").ejDialog("close");
    $("#changepasswordForm").ejDialog("close");
    $("#loginForm").ejDialog("close");

    $("#forgetpasswordForm").ejDialog("open");

});



function onLoginDialogClose(args){
    console.log(args);
}



function checklogin(args){
    var username = new RegExp('^[a-zA-Z0-9]{4,20}$');
    var pw = new RegExp('^[a-zA-Z0-9]{6,20}$');

    if(pw.test($("#password").val()) && username.test($("#username").val()) ){
        $("#loginbtn").data("ejButton").enable();
        return;
    }

    $("#loginbtn").data("ejButton").disable();
}

function checkregister(args){
    var flname = new RegExp('^[a-zA-Z]{4,40}$');
    var email = new RegExp('^[a-zA-Z]{4,40}$');
    var username = new RegExp('^[a-zA-Z0-9]{4,20}$');
    var pw = new RegExp('^[a-zA-Z0-9]{6,20}$');

    if( flname.test($('#rfirstlastname').val()) && email.test($('#remail').val()) && username.test($('#rusername').val()) && pw.test($('#rpassword').val()) && $('#rpassword').val() == $('#rpasswordc').val()){
        $("#registerbtn").data("ejButton").enable();
        return;
    }

    $("#registerbtn").data("ejButton").disable();
}

function loginclick(args){

    var auth = {"u" : $("#username").val() , "p" : $("#password").val() ,  "rem"  : $("#rememberme")[0].checked };
    login(auth);
}

function login(args){

    //just close dialog
    $("#loginForm").ejDialog("close");
}

function registerclick(args){

    var auth = {"firstlastname" : $('#rfirstlastname').val() , "username" : $("#rusername").val() ,  "email"  : $("#remail").val() , "password" : $("#rpassword").val()};
    register(auth);
}

function register(args){

    //just close dialog
    $("#loginForm").ejDialog("close");
}




