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
<script>
    function myMap () {
        var CDAM_Latlng = new google.maps.LatLng (-6.2363781, 106.7472634);
        var CDAM_mapOptions = {
            zoom: 15,
            center: CDAM_Latlng
        }
        var map = new google.maps.Map (document.getElementById ("googleMap"), CDAM_mapOptions);
        google.maps.event.trigger(map, 'resize');
        //markers icon :
        var iconHome = "marker.png";
        var otherpart = "marker.png";

        var CDAM_marker = new google.maps.Marker({
            animation: google.maps.Animation.DROP,
            position: CDAM_Latlng,
            map: map,
            title: 'Mobil Box A',
            icon: 'icon_marker.png'
        });

        // info_window content_string
        var CDAM_infoContent = '<div id="content" style="margin:0 auto; padding:0px;">' +
            '<h3>Mobil Box A</h3>' +
            '<ol><li>Tujuan : Manufaktur A</li><li>Pengemudi : Herman</li>' +'</ol>';

        // info window CDAM:
        var infowindowCDAM = new google.maps.InfoWindow({
            content: CDAM_infoContent
        });

        google.maps.event.addListener(CDAM_marker, 'mouseover', function () {
            infowindowCDAM.open(map, CDAM_marker);
        });

        google.maps.event.addListener(CDAM_marker, 'mouseout', function () {
            infowindowCDAM.close(map, CDAM_marker);
        });


        //Effect Click :
        google.maps.event.addListener(CDAM_marker, 'click', function toggleBounce() {
            if (CDAM_marker.getAnimation() != null) {
                CDAM_marker.setAnimation(null);
            } else {
                CDAM_marker.setAnimation(google.maps.Animation.BOUNCE);
            }
        });
    }
</script>
<script async defer src="https://maps.googleapis.com/maps/api/js?key=AIzaSyD9UdyFMvRp4O8g870f9I3_uWkStOhcAXg&callback=myMap" type="text/javascript"></script>


<script type="text/javascript">
    $ (document).ready (function () {
        
        $ ('#data-distributor').dataTable ({
            "aoColumns": [
                null,
                null,
                null,
                null,
                null
            ],
            "order": [
                [0, "asc"],
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
        $ ('#data-pesanan').dataTable ({
            "aoColumns": [
                null,
                null,
                null,
                null,
                null,
            ],
            "order": [
                [0, "asc"],
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
        $ ('#dataTables').dataTable ({
            "aoColumns": [
                null,
                null,
                null,
                null,
                null,
            ],
            "order": [
                [0, "asc"],
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
