function CopyInfo
{
	param([string] $Origen,
	[string] $Carpeta)
	Copy-InfoToPendrive -Origen $Origen -Carpeta $Carpeta
	}

workflow Copy-InfoToPendrive
{ 
	param([string] $Origen,
	[string] $Carpeta)
	$items = gwmi win32_diskdrive | ?{$_.interfacetype -eq "USB"} | %{gwmi -Query "ASSOCIATORS OF
	{Win32_DiskDrive.DeviceID=`"$($_.DeviceID.replace('\','\\'))`"}
	WHERE AssocClass = Win32_DiskDriveToDiskPartition"} | %{gwmi -Query "ASSOCIATORS OF
	{Win32_DiskPartition.DeviceID=`"$($_.DeviceID)`"}
	WHERE AssocClass =Win32_LogicalDiskToPartition"} | %{$_.deviceid}
	ForEach -Parallel ($item in $items)
	{  
		robocopy $Origen "$item\$Carpeta"
	}
}

export-modulemember -function CopyInfo