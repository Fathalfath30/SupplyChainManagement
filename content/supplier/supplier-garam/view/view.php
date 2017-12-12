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
?>

<div class="row">
    <div class="col-md-12">
        <a href="<?php echo base_url("manufaktur.php") ?>" class="btn btn-primary">
            <i class="fa fa-plus"></i> Tambah data baru
        </a>
    </div>
</div>
<div class="row"></div>
<div class="row" style="margin-top: 10px;">
    <div class="col-md-12">
        <div class="panel panel-visible" id="spy2">
            <div class="panel-heading">
                <div class="panel-title hidden-xs">
                    <<span class="glyphicon glyphicon-tasks"></span>Data <?php echo ucfirst($task) . " " . ucfirst(str_replace("-", " ", $obj)); ?></div>
            </div>
            <div class="panel-body pn">
                <table class="table table-bordered table-hover" id="dataTables" cellspacing="0" width="100%">
                    <thead>
                    <tr>
                        <th style="width: 10%;">Kode</th>
                        <th>Nama Supplier</th>
                        <th style="width: 20%;">Lokasi</th>
                        <th>Jarak (KM)</th>
                        <th style="width: 20%;">Stock Tersedia</th>
                        <th>Harga  Per 1 TON</th>
                        <th>Aksi</th>
                    </tr>
                    </thead>
                    <tbody>
                    <?php
                    for ( $i = 0; $i < count($app_data['SUPPLIER']['GARAM']); $i++ ) {
                        $data = $app_data['SUPPLIER']['GARAM'][sprintf("SPG%03d", $i + 1)];
                        ?>
                        <tr>
                            <td><?php echo $data['ID'] ?></td>
                            <td><?php echo $data['NAME'] ?></td>
                            <td><?php echo $data['LOC'] ?></td>
                            <td><?php echo $data['RANGE'] ?></td>
                            <td><?php echo $data['A_STOCK'] ?></td>
                            <td><?php echo $data['I_PRICE'] ?></td>
                            <td align="center">
                                <a href="<?php echo base_url(sprintf('manufaktur.php?task=detail&obj=garam&id=%s', $data['ID'])) ?>" class="label label-primary">Detail</a>
                                <a href="<?php echo base_url(sprintf('manufaktur.php?task=order&obj=garam&id=%s', $data['ID'])) ?>" class="label label-success">Order</a>
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