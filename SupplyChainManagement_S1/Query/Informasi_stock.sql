SELECT 
    a.kd_barang,
    c.kd_supplier,
    d.kd_gudang,
    nm_barang,
    nm_supplier,
    nm_gudang,
    tgl_masuk,
    min_stock,
    max_stock,
    jumlah_stock
FROM
    stock a
        INNER JOIN
    barang b ON b.kd_barang = a.kd_barang
        INNER JOIN
    supplier c ON a.kd_supplier = c.kd_supplier
        INNER JOIN
    gudang d ON d.kd_gudang = a.kd_gudang;