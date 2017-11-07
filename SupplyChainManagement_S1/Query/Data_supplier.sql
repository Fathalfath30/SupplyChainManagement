SELECT 
    a.id_supplier AS 'ID_SUPPLIER',
    nm_supplier AS 'NAMA_SUPPLIER',
    c.id_barang AS 'ID_BARANG',
    nm_barang AS 'NAMA_BARANG',
    lokasi_supplier AS 'LOKASI_SUPPLIER',
    telp_supplier AS 'NOMOR_TELP'
FROM
    supplier a
        INNER JOIN
    detil_supplier b ON a.id_supplier = b.id_supplier
        INNER JOIN
    barang c ON b.id_barang = c.id_barang;