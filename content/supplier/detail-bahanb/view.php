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
include 'app_data/DB_BahanBaku.php';
$data_id = $_GET['id'];
if (!isset($data_id)) {
    ?>
        <script type="text/javascript">
            document.location= '<?php echo base_url('manufaktur.php') ?>';
        </script>
    <?php
    exit();
}

$data = $app_data['BAHAN_BAKU'][$data_id];
?>
<div class="col-md-8">
    <form method="POST" action="" class="form-horizontal" id="input-form">
        <div class="panel">
            <div class="panel-heading">
                <span class="panel-title">Detail Bahan Baku <?php echo $data['NAME'] ?></span>
            </div>
            <div class="panel-body admin-form theme-primary">

                <div class="form-group">
                    <label class="col-lg-3 control-label">Kode Barang :</label>
                    <div class="col-lg-8">
                        <p class="form-control-static text-muted"><?php echo $data['ID'] ?></p>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-lg-3 control-label">Nama Barang :</label>
                    <div class="col-lg-8">
                        <p class="form-control-static text-muted"><?php echo $data['NAME'] ?></p>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-lg-3 control-label">Label Barang :</label>
                    <div class="col-lg-8">
                        <p class="form-control-static text-muted"><?php echo $data['LABEL'] ?></p>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-lg-3 control-label">Tanggal Masuk :</label>
                    <div class="col-lg-8">
                        <p class="form-control-static text-muted"><?php echo $data['DATE_IN'] ?></p>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-lg-3 control-label">Stock :</label>
                    <div class="col-lg-8">
                        <p class="form-control-static text-muted"><?php echo $data['A_STOCK'] ?></p>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-lg-3 control-label">Lokasi Gudang :</label>
                    <div class="col-lg-8">
                        <p class="form-control-static text-muted"><?php echo $data['LOC'] ?></p>
                    </div>
                </div>

            </div>
            <div class="panel-footer text-right">
                <button type="button" class="btn btn-default" onclick="history.go(-1)">Kembali</button>
            </div>
        </div>
    </form>
</div>