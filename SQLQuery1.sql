use CSDLThuVien
ALTER PROC UpdateImage
@MSSach varchar(6),
@HinhBia IMAGE
AS
	BEGIN
		Update dbo.Sach
		Set HinhBia=@HinhBia
		Where MSSach=@MSSach
	END; 