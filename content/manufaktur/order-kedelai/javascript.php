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
?>
<script type="text/javascript">
    $("#BtnOrder").on('click', function () {
        var Input = $("#jumlah_pesanan");
        var Stock = "<?php echo $data['A_STOCK'] ?>";
        var Supplier = "<?php echo $data['NAME'] ?>";
        var Loc = "<?php echo $data['LOC'] ?>";
        if (Input.val() < 1) {
            alert("Masukan jumlah pesanan, minimal 1.");
            Input.val("1");
            Input.focus();
        } else if (Input.val() > Stock) {
            alert("Maaf stock yang tersedia hanya : " + Stock);
            Input.val(Stock);
            Input.focus();
        } else {
            alert("Terima kasih, barang anda sedang di proses oleh manufaktur\n\nManufaktur : " + Supplier + "\nLokasi : " + Loc );
        }
    });
</script>
