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
include 'app_data/DB_BahanBaku.php';
include 'app_data/DB_Sp.php'

?>

<div class="row"></div>
<div class="row" style="margin-top: 10px;">
    <div class="col-md-12">
        <div class="panel panel-visible" id="spy2">
            <div class="panel-heading">
                <div class="panel-title hidden-xs">
                    <span class="glyphicon glyphicon-tasks"></span>Data Pembelian</div>
            </div>
            <div class="panel-body pn">
                <table class="table table-bordered table-hover" id="dataTables" cellspacing="0" width="100%">
                    <thead>
                    <tr>
                        <th style="width: 10%;">Kode</th>
                        <th>Nama Barang</th>
                        <th>Harga Satuan</th>
                        <th>Total Beli</th>
                        <th>Total Harga</th>
                        <th>Aksi</th>
                    </tr>
                    </thead>
                    <tbody>
                    <?php
                    foreach ($app_data['SURAT_PESAN'] as $key => $val) {
                        $Id_barang = $app_data['SURAT_PESAN'][$key]['ID_BARANG'];
                        $Id_supplier = $app_data['SURAT_PESAN'][$key]['ID_SUP'];
                        $Data_barang = $app_data['BAHAN_BAKU'][$Id_barang];

                        $WHERE = substr($Id_supplier, 0, 3);
                        $RS = "";
                        if ($WHERE == "SPK")
                            $RS = "KEDELAI_HITAM";

                        $Data_supplier = $app_data['SUPPLIER'][$RS][$Id_supplier];
                        ?>
                        <tr>
                            <td><?php echo $val['ID'] ?></td>
                            <td><?php echo $Data_barang['NAME'] ?></td>
                            <td><?php echo $Data_supplier['I_PRICE'] ?></td>
                            <td><?php echo $val['JUMLAH'] ?></td>
                            <td><?php
                                $price = str_replace("Rp.", "", $Data_supplier['I_PRICE']);
                                $price = str_replace(".", "", $price);
                                echo sprintf("Rp. %s", number_format($price * $val['JUMLAH'], 0));
                                ?></td>
                            <td align="center">
                                <a href="<?php echo base_url(sprintf('manufaktur.php?task=detail&obj=botol&id=%s', $data['ID'])) ?>" class="label label-primary">Detail</a>
                            </td>
                        </tr>
                        <?php
                    }
                    ?>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>
