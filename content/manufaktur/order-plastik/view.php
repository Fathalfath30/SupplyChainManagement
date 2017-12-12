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
include 'app_data/DB_Supplier.php';
$data_id = $_GET['id'];
if (!isset($data_id)) {
    ?>
        <script type="text/javascript">
            document.location= '<?php echo base_url('manufaktur.php') ?>';
        </script>
    <?php
    exit();
}

// print_r($app_data['SUPPLIER']);
$data = $app_data['SUPPLIER']['PLASTIK'][$data_id];
?>
<div class="col-md-8">
    <form method="POST" action="" class="form-horizontal" id="input-form">
        <div class="panel">
            <div class="panel-heading">
                <span class="panel-title">Detail Bahan Baku <?php echo $data['NAME'] ?></span>
            </div>
            <div class="panel-body admin-form theme-primary">

                <div class="form-group">
                    <label class="col-lg-3 control-label">Kode Supplier :</label>
                    <div class="col-lg-8">
                        <p class="form-control-static text-muted"><?php echo $data['ID'] ?></p>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-lg-3 control-label">Nama Supplier :</label>
                    <div class="col-lg-8">
                        <p class="form-control-static text-muted"><?php echo $data['NAME'] ?></p>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-lg-3 control-label">Harga :</label>
                    <div class="col-lg-8">
                        <p class="form-control-static text-muted"><?php echo $data['I_PRICE'] ?></p>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-lg-3 control-label">Jarak :</label>
                    <div class="col-lg-8">
                        <p class="form-control-static text-muted"><?php echo $data['RANGE'] ?> KM</p>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-lg-3 control-label">Stock Tersedia :</label>
                    <div class="col-lg-8">
                        <p class="form-control-static text-muted"><?php echo $data['A_STOCK'] ?></p>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-lg-3 control-label">Lokasi Supplier :</label>
                    <div class="col-lg-8">
                        <p class="form-control-static text-muted"><?php echo $data['LOC'] ?></p>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-lg-3 control-label">Telp :</label>
                    <div class="col-lg-8">
                        <p class="form-control-static text-muted"><?php echo $data['TELP'] ?></p>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-lg-3 control-label"> Jumlah Pesanan :</label>
                    <div class="col-lg-8">
                        <div class="section">
                            <label for="Jumlah pesanan" class="field prepend-icon">
                                <input type="text" name="jumlah_pesanan" id="jumlah_pesanan" class="gui-input"
                                       placeholder="Jumlah pesanan (Minimal 1 Lembar">
                                <label for="Jumlah pesanan (Minimal 1)" class="field-icon"><i class="glyphicons glyphicons-more_items"></i></label>
                            </label>
                        </div>
                    </div>
                </div>
            </div>
            <div class="panel-footer text-right">
                <button type="button" class="btn btn-default" onclick="history.go(-1)">Kembali</button>
                <a id="BtnOrder" href="#" class="btn btn-success">Order</a>
            </div>
        </div>
    </form>
</div>