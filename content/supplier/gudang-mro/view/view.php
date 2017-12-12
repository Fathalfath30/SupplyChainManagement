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
<div class="row" style="margin-top: 10px;">
    <div class="col-md-12">
        <div class="panel panel-visible" id="spy2">
            <div class="panel-heading">
                <div class="panel-title hidden-xs">
                    <span class="glyphicon glyphicon-tasks"></span>Data <?php echo ucfirst($task) . " " . ucfirst(str_replace("-", " ", $obj)); ?></div>
            </div>
            <div class="panel-body pn">
                <table class="table table-bordered table-hover" id="dataTables" cellspacing="0" width="100%">
                    <thead>
                    <tr>
                        <th style="width: 10%;">Kode</th>
                        <th>Nama Barang</th>
                        <th style="width: 20%;">Label</th>
                        <th>Tanggal Masuk</th>
                        <th>Tanggal Kadaluarsa</th>
                        <th style="width: 20%;">Jumlah Produksi</th>
                        <th>Aksi</th>
                    </tr>
                    </thead>
                    <tbody>
                    <tr>
                        <td>GBJ001</td>
                        <td>Bango BTL 135ML</td>
                        <td>BBTL135-010217</td>
                        <td>01 Februari 2017</td>
                        <td>01 Februari 2018</td>
                        <td>215 Buah</td>
                        <td align="center">
                            <a href="#" class="label label-primary col-lg-12 label-sm">Detail</a>
                        </td>
                    </tr>
                    <tr>
                        <td>GBJ002</td>
                        <td>Bango BTL 275ML</td>
                        <td>BBTL275-010217</td>
                        <td>01 Februari 2017</td>
                        <td>01 Februari 2018</td>
                        <td>216 Buah</td>
                        <td align="center">
                            <a href="#" class="label label-primary col-lg-12 label-sm">Detail</a>
                        </td>
                    </tr>
                    <tr>
                        <td>GBJ003</td>
                        <td>Bango BTL 620ML</td>
                        <td>BBTL620-010217</td>
                        <td>01 Februari 2017</td>
                        <td>01 Februari 2018</td>
                        <td>215 Buah</td>
                        <td align="center">
                            <a href="#" class="label label-primary col-lg-12 label-sm">Detail</a>
                        </td>
                    </tr>
                    <tr>
                        <td>GBJ004</td>
                        <td>Bango RFL 600ML</td>
                        <td>BRFL600-010217</td>
                        <td>01 Februari 2017</td>
                        <td>01 Februari 2018</td>
                        <td>192 Buah</td>
                        <td align="center">
                            <a href="#" class="label label-primary col-lg-12 label-sm">Detail</a>
                        </td>
                    </tr>
                    <tr>
                        <td>GBJ005</td>
                        <td>Bango RFL 220ML</td>
                        <td>BRFL220-010217</td>
                        <td>01 Februari 2017</td>
                        <td>01 Februari 2018</td>
                        <td>162 Buah</td>
                        <td align="center">
                            <a href="#" class="label label-primary col-lg-12 label-sm">Detail</a>
                        </td>
                    </tr>
                    <tr>
                        <td>GBJ006</td>
                        <td>Bango RFL 85ML</td>
                        <td>BRFL85-010217</td>
                        <td>01 Februari 2017</td>
                        <td>01 Februari 2018</td>
                        <td>152 Buah</td>
                        <td align="center">
                            <a href="#" class="label label-primary col-lg-12 label-sm">Detail</a>
                        </td>
                    </tr>
                    <tr>
                        <td>GBJ007</td>
                        <td>Bango RFL 220ML</td>
                        <td>BRFL35-010217</td>
                        <td>01 Februari 2017</td>
                        <td>01 Februari 2018</td>
                        <td>102 Buah</td>
                        <td align="center">
                            <a href="#" class="label label-primary col-lg-12 label-sm">Detail</a>
                        </td>
                    </tr>
                    <tr>
                        <td>GBJ008</td>
                        <td>Bango RFL 85ML</td>
                        <td>BRFL85-210117</td>
                        <td>21 Januari 2017</td>
                        <td>21 Januari 2018</td>
                        <td>23 Buah</td>
                        <td align="center">
                            <a href="#" class="label label-primary col-lg-12 label-sm">Detail</a>
                        </td>
                    </tr>
                    <tr>
                        <td>GBJ009</td>
                        <td>Bango RFL 220ML</td>
                        <td>BRFL35-210117</td>
                        <td>21 Januari 2017</td>
                        <td>21 Januari 2018</td>
                        <td>15 Buah</td>
                        <td align="center">
                            <a href="#" class="label label-primary col-lg-12 label-sm">Detail</a>
                        </td>
                    </tr>
                    <tr>
                        <td>GBJ010</td>
                        <td>Bango BTL 135ML</td>
                        <td>BBTL135-210117</td>
                        <td>21 Januari 2017</td>
                        <td>21 Januari 2018</td>
                            <td>25 Buah</td>
                        <td align="center">
                            <a href="#" class="label label-primary col-lg-12 label-sm">Detail</a>
                        </td>
                    </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>