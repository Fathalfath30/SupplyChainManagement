<?php
//
// Script 	: javascript.php
// Author	: Fathalfath30
// Email	: fathalfath30@gmail.com
// Created	: 25/01/2017 12.36
// Version  : 1.0
//
// Licensed under GNU General Public License v3.0
// http://www.gnu.org/licenses/gpl-3.0.txt
//
?>
<script type="text/javascript">
    $ (document).ready (function () {
        $ ('#dataTables').dataTable ({
            "aoColumns": [
                null,
                null,
                null,
                null,
                null,
                {"bSortable": false}
            ],
            "order": [
                [3, "asc"],
                [4, "asc"]
            ],
            "oLanguage": {
                "oPaginate": {
                    "sPrevious": "",
                    "sNext": ""
                }
            },
            "iDisplayLength": 10,
            "aLengthMenu": [
                [10, 25, 50, -1],
                [10, 25, 50, "All"]
            ],
            "sDom": '<"dt-panelmenu clearfix"lfr>t<"dt-panelfooter clearfix"ip>',
            "oTableTools": {
                "sSwfPath": "vendor/plugins/datatables/extensions/TableTools/swf/copy_csv_xls_pdf.swf"
            }
        });
    });

    function RemoveData (lstid) {
        $.magnificPopup.open ({
            removalDelay: 300, //delay removal by X to allow out-animation,
            items: {
                src: "#modal-hapus"
            },
            // overflowY: 'hidden', //
            mainClass: 'mfp-fade'
            // midClick: true // allow opening popup on middle mouse click. Always set it to true if you don't provide alternative source.
        });

        $ ("#ok-delete-me").click (function () {
            document.location = '<?php echo base_url("admin/matakuliah/hapus?id=") ?>' + lstid;
        });
    }
</script>
