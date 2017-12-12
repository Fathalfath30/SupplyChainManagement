<?php
/*
 //
 //    ______    _   _           _  __      _   _     ____   ___
 //   |  ____|  | | | |         | |/ _|    | | | |   |___ \ / _ \
 //   | |__ __ _| |_| |__   __ _| | |_ __ _| |_| |__   __) | | | |
 //   |  __/ _` | __| '_ \ / _` | |  _/ _` | __| '_ \ |__ <| | | |
 //   | | | (_| | |_| | | | (_| | | || (_| | |_| | | |___) | |_| |
 //   |_|  \__,_|\__|_| |_|\__,_|_|_| \__,_|\__|_| |_|____/ \___/
 //
 // Licensed under GNU General Public License v3.0
 // http://www.gnu.org/licenses/gpl-3.0.txt
 // Written by Fathalfath30. Email : fathalfath30@gmail.com
 // Follow me on GithHub : https://github.com/Fathalfath30
 //
*/

getCss(array(
    "assets/skin/default_skin/css/theme.css",
    "assets/admin-tools/admin-plugins/admin-panels/adminpanels.css",
    "assets/admin-tools/admin-forms/css/admin-forms.css",
    "assets/fonts/icomoon/icomoon.css",
    "assets/vendor/plugins/magnific/magnific-popup.css",
    "assets/fonts/open-sans/open-sans.css",
    "assets/fonts/roboto/roboto.css",
    "assets/vendor/plugins/datatables/media/css/dataTables.bootstrap.css",
    "assets/vendor/plugins/datatables/extensions/Editor/css/dataTables.editor.css"
));
?>
<link rel="shortcut icon" href="<?php echo base_url("assets/img/logo.png") ?>">

<!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
<!--[if lt IE 9]>
<?php
    getJavascript(array(
        "assets/js/html5/html5shiv.js",
        "assets/js/html5/respond.min.js"
    ));
?>
<![endif]-->
<style type="text/css">
    #dataTables th {
        font-weight: bold;
    }

</style>
