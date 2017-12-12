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

getJavascript(array (
    "assets/vendor/jquery/jquery-1.11.1.min.js",
    "assets/vendor/jquery/jquery_ui/jquery-ui.min.js",
    "assets/js/bootstrap/bootstrap.min.js",
    "assets/js/jquery.sparkline.min.js",
    "assets/js/bootstrap/holder.min.js",
    "assets/js/utility/utility.js",
    "assets/js/main.js",
    "assets/vendor/plugins/magnific/jquery.magnific-popup.js",
    "assets/admin-tools/admin-forms/js/jquery.validate.min.js",
    "assets/vendor/plugins/datatables/media/js/jquery.dataTables.js",
    "assets/vendor/plugins/datatables/extensions/TableTools/js/dataTables.tableTools.min.js",
    "assets/vendor/plugins/datatables/media/js/dataTables.bootstrap.js",
));
?>
<script type="text/javascript">
    $ (document).ready (function () {
        "use strict";

        // Init Theme Core
        Core.init ({
            sbm: "sb-l-c"
        });

        $ (".nano").nanoScroller ({sliderMaxHeight: 5500});
    });
</script>
<?php
switch ($task) {
    case 'dashboard' :
        include 'content/manufaktur/dashboard/javascript.php';
        break;
    case 'po':
        include 'content/manufaktur/po-bahan-baku/javascript.php';
        break;
    case 'jadwal-kirim':
        include 'content/manufaktur/jadwal-kirim/javascript.php';
        break;
}
?>
