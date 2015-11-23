﻿using System;
using Synology.Classes;
using Synology.Utilities;

namespace Synology.Info
{
	public class InfoRequest : SynologyRequest
	{
		internal InfoRequest(SynologyConnection connection) : base(connection, "query.cgi", "SYNO.API.Info")
		{
		}

		public object Info()
		{
			/*
					{ "data" : { "SYNO.ACEEditor" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.ACEEditor.Preference" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.API.Auth" : { "maxVersion" : 4,
					  "minVersion" : 1,
					  "path" : "auth.cgi"
					},
				  "SYNO.API.Encryption" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "encryption.cgi"
					},
				  "SYNO.API.Info" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "query.cgi"
					},
				  "SYNO.AudioPlayer.Stream" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "AudioPlayer/stream.cgi"
					},
				  "SYNO.AudioStation.Album" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "AudioStation/album.cgi"
					},
				  "SYNO.AudioStation.Artist" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "AudioStation/artist.cgi"
					},
				  "SYNO.AudioStation.Composer" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "AudioStation/composer.cgi"
					},
				  "SYNO.AudioStation.Cover" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "AudioStation/cover.cgi"
					},
				  "SYNO.AudioStation.Download" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "AudioStation/download.cgi"
					},
				  "SYNO.AudioStation.Folder" : { "maxVersion" : 3,
					  "minVersion" : 1,
					  "path" : "AudioStation/folder.cgi"
					},
				  "SYNO.AudioStation.Genre" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "AudioStation/genre.cgi"
					},
				  "SYNO.AudioStation.Info" : { "maxVersion" : 4,
					  "minVersion" : 1,
					  "path" : "AudioStation/info.cgi"
					},
				  "SYNO.AudioStation.Lyrics" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "AudioStation/lyrics.cgi"
					},
				  "SYNO.AudioStation.LyricsSearch" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "AudioStation/lyrics_search.cgi"
					},
				  "SYNO.AudioStation.MediaServer" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "AudioStation/media_server.cgi"
					},
				  "SYNO.AudioStation.Playlist" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "AudioStation/playlist.cgi"
					},
				  "SYNO.AudioStation.Proxy" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "AudioStation/proxy.cgi"
					},
				  "SYNO.AudioStation.Radio" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "AudioStation/radio.cgi"
					},
				  "SYNO.AudioStation.RemotePlayer" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "AudioStation/remote_player.cgi"
					},
				  "SYNO.AudioStation.RemotePlayerStatus" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "AudioStation/remote_player_status.cgi"
					},
				  "SYNO.AudioStation.Search" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "AudioStation/search.cgi"
					},
				  "SYNO.AudioStation.Song" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "AudioStation/song.cgi"
					},
				  "SYNO.AudioStation.Stream" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "AudioStation/stream.cgi"
					},
				  "SYNO.AudioStation.WebPlayer" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "AudioStation/web_player.cgi"
					},
				  "SYNO.Backup.App" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.App.Backup" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.App.Restore" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Config.Backup" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Config.Restore" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Log" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Repository" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Repository.Certificate" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Repository.PrivilegedUser" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Restore" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Server" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Service.NetworkBackup" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Service.TimeBackup" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Service.VersionBackup" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Share.Restore" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Source.Folder" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Storage.Connect.Network" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Storage.S3.Bucket" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Storage.S3.Region" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Storage.Share.Local" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Storage.Volume.Local" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Target" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Target.File" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Target.Folder" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Target.Owner" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Target.PrivilegedUser" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Task" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Task.Data" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Backup.Version" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.CloudSync" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.ACL" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.AHA" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.AHA.Enclosure" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.AHA.Log" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.AHA.Monitor" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.AHA.Network" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.AHA.Node" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.AppNotify" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.AppPortal" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.AppPortal.Config" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.AppPortal.Image" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.AppPortal.Style" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.AppPriv" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.AppPriv.App" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.AppPriv.Rule" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.BandwidthControl" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.BandwidthControl.Protocol" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.BandwidthControl.Status" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.CMS" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.CMS.Cache" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.CMS.Info" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.CMS.Policy" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.CMS.ServerInfo" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.CMS.Token" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Certificate" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Certificate.CRT" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Certificate.CSR" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.CurrentConnection" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.DDNS.ExtIP" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.DDNS.Provider" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.DDNS.Record" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.DDNS.Synology" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.DataCollect" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.DataCollect.Application" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Desktop.Timeout" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Directory.Domain" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Directory.Domain.Conf" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Directory.Domain.Schedule" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Directory.LDAP" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Directory.LDAP.BaseDN" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Directory.LDAP.Profile" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Directory.SSO" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Directory.SSO.utils" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.ExternalDevice.Bluetooth" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.ExternalDevice.Bluetooth.Device" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.ExternalDevice.Bluetooth.Settings" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.ExternalDevice.DefaultPermission" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.ExternalDevice.Printer" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.ExternalDevice.Printer.BonjourSharing" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.ExternalDevice.Printer.Driver" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.ExternalDevice.Printer.Network" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.ExternalDevice.Printer.Network.Host" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.ExternalDevice.Printer.OAuth" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.ExternalDevice.Printer.USB" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.ExternalDevice.Storage.EUnit" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.ExternalDevice.Storage.SD" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.ExternalDevice.Storage.Setting" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.ExternalDevice.Storage.USB" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.ExternalDevice.Storage.eSATA" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.ExternalDevice.UPS" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.EzInternet" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.File" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.File.Thumbnail" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.FileServ.AFP" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.FileServ.FTP" : { "maxVersion" : 3,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.FileServ.FTP.ChrootUser" : { "maxVersion" : 2,
					  "minVersion" : 2,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.FileServ.FTP.SFTP" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.FileServ.FTP.Security" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.FileServ.NFS" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.FileServ.NFS.AdvancedSetting" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.FileServ.NFS.IDMap" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.FileServ.NFS.Kerberos" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.FileServ.NFS.SharePrivilege" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.FileServ.SMB" : { "maxVersion" : 3,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.FileServ.WebDAV" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.FileServ.WebDAV.CalDAV" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.FileServ.WebDAV.CalDAV.Calendar" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Group" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Group.Member" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Hardware.BeepControl" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Hardware.DCOutput" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Hardware.DCOutput.Task" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Hardware.FanSpeed" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Hardware.Hibernation" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Hardware.LCM" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Hardware.Led.Brightness" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Hardware.MemoryLayout" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Hardware.PowerRecovery" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Hardware.PowerSchedule" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Hardware.ZRAM" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.MediaIndexing" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.MediaIndexing.IndexFolder" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.MediaIndexing.MediaConverter" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.MyDSCenter" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.MyDSCenter.Account" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.MyDSCenter.Purchase" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.MyDSCenter.Unify" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.Bond" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.Bridge" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.DHCPServer" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.DHCPServer.ClientList" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.DHCPServer.PXE" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.DHCPServer.Reservation" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.DHCPServer.WPAD" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.Ethernet" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.IPv6" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.IPv6.Router" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.IPv6.Router.Prefix" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.IPv6Tunnel" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.Interface" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.LocalBridge" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.MACClone" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.PPPoE" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.PPPoE.Relay" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.Proxy" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.Router.ConnectionList" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.Router.CountryCode" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.Router.DMZ" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.Router.Gateway.List" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.Router.LocalLan" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.Router.MacFilter" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.Router.ParentalControl" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.Router.PkgList" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.Router.PortForward" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.Router.Static.Route" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.Router.Topology" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.TrafficControl.RouterRules" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.TrafficControl.Rules" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.UPnPServer" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.USBModem" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.VPN" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.VPN.L2TP" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.VPN.OpenVPN" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.VPN.OpenVPN.CA" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.VPN.PPTP" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.WOL" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.Wifi.Client" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.Wifi.Hotspot" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Network.Wifi.WPS" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Notification.Advance.CustomizedData" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Notification.Advance.FilterSettings" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Notification.Advance.Variables" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Notification.Advance.WarningPercentage" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Notification.CMS" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Notification.CMS.Conf" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Notification.Mail" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Notification.Mail.Auth" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Notification.Mail.Conf" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Notification.Push" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Notification.Push.AuthToken" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Notification.Push.Conf" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Notification.Push.Mail" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Notification.Push.Mobile" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Notification.SMS" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Notification.SMS.Conf" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Notification.SMS.Provider" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.OTP" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.OTP.EnforcePolicy" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Package" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Package.Control" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Package.Installation" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Package.Server" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Package.Setting" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Package.Uninstallation" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.PortForwarding" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.PortForwarding.Compatibility" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.PortForwarding.RouterConf" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.PortForwarding.RouterInfo" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.PortForwarding.RouterList" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.PortForwarding.Rules" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.PortForwarding.Rules.Serv" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.QuickConnect" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.QuickConnect.Permission" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.QuickConnect.Upnp" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Quota" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.RecycleBin" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.RecycleBin.User" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Region.Language" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Region.NTP" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Region.NTP.Server" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Report" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Report.Analyzer" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Report.Config" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Report.History" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.SNMP" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Security.AutoBlock" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Security.AutoBlock.Rules" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Security.DSM" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Security.DSM.Embed" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Security.DoS" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Security.Firewall.Conf" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Security.Firewall.Rules" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Security.Firewall.Rules.Serv" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Security.VPNPassthrough" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Security.VPNPassthrough.Status" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.SecurityScan.Conf" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.SecurityScan.Operation" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.SecurityScan.Status" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Service" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Service.Conf" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Service.PortInfo" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Share" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Share.Crypto" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Share.Crypto.Key" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Share.CryptoFile" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Share.Fileindex" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Share.Migration" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Share.Migration.Task" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Share.Permission" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Share.Snapshot" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Storage.Disk" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Storage.Pool" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Storage.Volume" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Storage.iSCSILUN" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Storage.iSCSITargets" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.SupportForm.Form" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.SupportForm.Log" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.SupportForm.Service" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.SyslogClient" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.SyslogClient.CA" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.SyslogClient.CustRule" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.SyslogClient.FileTransfer" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.SyslogClient.History" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.SyslogClient.Log" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.SyslogClient.PersonalActivity" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.SyslogClient.Setting.Notify" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.SyslogClient.Setting.Server" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.SyslogClient.Setting.Storage" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.SyslogClient.Status" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.System" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.System.Utilization" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.TFTP" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.TaskScheduler" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Terminal" : { "maxVersion" : 3,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Theme.Image" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Theme.Login" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Upgrade" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Upgrade.AutoUpgrade" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Upgrade.Group" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Upgrade.Group.Download" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Upgrade.GroupInstall" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Upgrade.GroupInstall.Network" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Upgrade.Patch" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Upgrade.Server" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Upgrade.Server.Download" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Upgrade.Setting" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.User" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.User.Home" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.User.PasswordPolicy" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.UserSettings" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Web.DSM" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Web.DSM.External" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Web.HTTP" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Web.HTTP.Dependency" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Web.HTTP.VHost" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Web.PHP" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Core.Web.PHP.Extension" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.DSM.Application" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "dsm/app.cgi"
					},
				  "SYNO.DSM.AutoBlock" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "dsm/autoblock.cgi"
					},
				  "SYNO.DSM.Connection" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "dsm/connection.cgi"
					},
				  "SYNO.DSM.FindMe" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "dsm/findme.cgi"
					},
				  "SYNO.DSM.Group" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "dsm/group.cgi"
					},
				  "SYNO.DSM.Info" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "dsm/info.cgi"
					},
				  "SYNO.DSM.LogViewer" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "dsm/logviewer.cgi"
					},
				  "SYNO.DSM.Network" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "dsm/network.cgi"
					},
				  "SYNO.DSM.Package" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "dsm/package.cgi"
					},
				  "SYNO.DSM.PushNotification" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "dsm/notification.cgi"
					},
				  "SYNO.DSM.Service" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "dsm/service.cgi"
					},
				  "SYNO.DSM.System" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "dsm/system.cgi"
					},
				  "SYNO.DSM.SystemLoading" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "dsm/system_loading.cgi"
					},
				  "SYNO.DSM.User" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "dsm/user.cgi"
					},
				  "SYNO.DSM.Volume" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "dsm/volume.cgi"
					},
				  "SYNO.DSM.iSCSI" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "dsm/iscsi.cgi"
					},
				  "SYNO.DTV.Channel" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/channellist.cgi"
					},
				  "SYNO.DTV.ChannelScan" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/channelscan.cgi"
					},
				  "SYNO.DTV.Controller" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/dtvcontrol.cgi"
					},
				  "SYNO.DTV.DVBSScan" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/dvbsscan.cgi"
					},
				  "SYNO.DTV.Program" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/programlist.cgi"
					},
				  "SYNO.DTV.Schedule" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/schedule_recording.cgi"
					},
				  "SYNO.DTV.Statistic" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/dtvstatistic.cgi"
					},
				  "SYNO.DTV.Status" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/dvtstatus.cgi"
					},
				  "SYNO.DTV.Streaming" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/dtvstreaming.cgi"
					},
				  "SYNO.DTV.Tuner" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/tuner.cgi"
					},
				  "SYNO.DisasterRecovery.Log" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.DisasterRecovery.Retention" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Docker.Container" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Docker.Container.Log" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Docker.Container.Profile" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Docker.Container.Resource" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Docker.Image" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Docker.Log" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Docker.Registry" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.DownloadStation.BTSearch" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "DownloadStation/btsearch.cgi"
					},
				  "SYNO.DownloadStation.Info" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "DownloadStation/info.cgi"
					},
				  "SYNO.DownloadStation.RSS.Feed" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "DownloadStation/RSSfeed.cgi"
					},
				  "SYNO.DownloadStation.RSS.Site" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "DownloadStation/RSSsite.cgi"
					},
				  "SYNO.DownloadStation.Schedule" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "DownloadStation/schedule.cgi"
					},
				  "SYNO.DownloadStation.Statistic" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "DownloadStation/statistic.cgi"
					},
				  "SYNO.DownloadStation.Task" : { "maxVersion" : 3,
					  "minVersion" : 1,
					  "path" : "DownloadStation/task.cgi"
					},
				  "SYNO.DownloadStation.Xunlei.Task" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "DownloadStation/xunlei/dl_queue.cgi"
					},
				  "SYNO.DownloadStation2.Task" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.DownloadStation2.Task.BT" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.DownloadStation2.Task.BT.File" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.DownloadStation2.Task.BT.Peer" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.DownloadStation2.Task.BT.Tracker" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.DownloadStation2.Task.List" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.DownloadStation2.Thumbnail" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Entry.Request" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Entry.Request.Polling" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.FileStation.BackgroundTask" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "FileStation/background_task.cgi"
					},
				  "SYNO.FileStation.CheckExist" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "FileStation/file_checkDir.cgi"
					},
				  "SYNO.FileStation.CheckPermission" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "FileStation/file_permission.cgi"
					},
				  "SYNO.FileStation.Compress" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "FileStation/file_compress.cgi"
					},
				  "SYNO.FileStation.CopyMove" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "FileStation/file_MVCP.cgi"
					},
				  "SYNO.FileStation.CreateFolder" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "FileStation/file_crtfdr.cgi"
					},
				  "SYNO.FileStation.Delete" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "FileStation/file_delete.cgi"
					},
				  "SYNO.FileStation.DirSize" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "FileStation/file_dirSize.cgi"
					},
				  "SYNO.FileStation.Download" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "FileStation/file_download.cgi"
					},
				  "SYNO.FileStation.Extract" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "FileStation/file_extract.cgi"
					},
				  "SYNO.FileStation.Favorite" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "FileStation/file_favorite.cgi"
					},
				  "SYNO.FileStation.Info" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "FileStation/info.cgi"
					},
				  "SYNO.FileStation.List" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "FileStation/file_share.cgi"
					},
				  "SYNO.FileStation.MD5" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "FileStation/file_md5.cgi"
					},
				  "SYNO.FileStation.OpenGoogleDrive" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "FileStation/file_opengdrive.cgi"
					},
				  "SYNO.FileStation.Rename" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "FileStation/file_rename.cgi"
					},
				  "SYNO.FileStation.Search" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "FileStation/file_find.cgi"
					},
				  "SYNO.FileStation.Sharing" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "FileStation/file_sharing.cgi"
					},
				  "SYNO.FileStation.Snapshot" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "FileStation/file_snapshot.cgi"
					},
				  "SYNO.FileStation.Thumb" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "FileStation/file_thumb.cgi"
					},
				  "SYNO.FileStation.Upload" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "FileStation/api_upload.cgi"
					},
				  "SYNO.FileStation.VFS.Connection" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.FileStation.VFS.GDrive" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.FileStation.VFS.Profile" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.FileStation.VFS.Protocol" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.FileStation.VFS.User" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.FileStation.VirtualFolder" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "FileStation/file_virtual.cgi"
					},
				  "SYNO.FolderSharing.Download" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "FolderSharing/file_download.cgi"
					},
				  "SYNO.FolderSharing.List" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "FolderSharing/file_share.cgi"
					},
				  "SYNO.FolderSharing.Thumb" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "FolderSharing/file_thumb.cgi"
					},
				  "SYNO.NoteStation.Export.Note" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Export.Notebook" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.FTS" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Import.Evernote" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Import.Notebook" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Info" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Note" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Note.AppLink" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Note.Encrypt" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Note.Ghost" : { "maxVersion" : 2,
					  "minVersion" : 2,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Note.Polling" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Note.Version" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Notebook" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Notebook.Polling" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Notebook.Preset" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Permission" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Permission.Public" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Permission.User" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Setting" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Setting.DSM" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Shard" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Shard.Link" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Share.Priv" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Shortcut" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Stack" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Tag" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.NoteStation.Todo" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.Package" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.PersonMailAccount" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.PersonMailAccount.Contacts" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.PersonMailAccount.Mail" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.ResourceMonitor.Setting" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.S2S.Client" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.S2S.Client.Job" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.S2S.Server" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.S2S.Server.Pair" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SocialAccount" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SocialAccount.Friend" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SocialAccount.Token" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.ActionRule" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.AddOns" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Alert" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Alert.Setting" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Analytics.Setting" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.AudioOut" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.AudioPattern" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.AudioStream" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "SurveillanceStation/audioStreaming.cgi"
					},
				  "SYNO.SurveillanceStation.AxisAcsCtrler" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.AxisAcsCtrler.Search" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.CMS" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.CMS.GetDsStatus" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.CMS.SlavedsWizard" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Camera" : { "maxVersion" : 8,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Camera.Event" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Camera.Group" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Camera.Import" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Camera.Status" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Camera.Wizard" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Device" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "SurveillanceStation/device.cgi"
					},
				  "SYNO.SurveillanceStation.DigitalOutput" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Emap" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Event" : { "maxVersion" : 5,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Event.Export" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Event.Mount" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.ExternalDevice.Storage.USB" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.ExternalEvent" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.ExternalRecording" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Info" : { "maxVersion" : 5,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.JoystickSetting" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Layout" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.License" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.LocalDisplay" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Log" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Notification" : { "maxVersion" : 3,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Notification.Email" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Notification.Filter" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Notification.PushService" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Notification.SMS" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Notification.SMS.ServiceProvider" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Notification.Schedule" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.PTZ" : { "maxVersion" : 4,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.PTZ.Preset" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.PersonalSettings.Image" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.RecordingPicker" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Share" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.SnapShot" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Sort" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Stream" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.Streaming" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "SurveillanceStation/streaming.cgi"
					},
				  "SYNO.SurveillanceStation.TaskQueue" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.VideoStream" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "SurveillanceStation/videoStreaming.cgi"
					},
				  "SYNO.SurveillanceStation.VideoStreaming" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.VisualStation" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.VisualStation.Layout" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.SurveillanceStation.VisualStation.Search" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "_______________________________________________________entry.cgi",
					  "requestFormat" : "JSON"
					},
				  "SYNO.VideoController.Device" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoController/device.cgi"
					},
				  "SYNO.VideoController.Password" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoController/password.cgi"
					},
				  "SYNO.VideoController.Playback" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "VideoController/playback.cgi"
					},
				  "SYNO.VideoController.Volume" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoController/volume.cgi"
					},
				  "SYNO.VideoStataion.Poster" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/poster.cgi"
					},
				  "SYNO.VideoStation.AudioTrack" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/audiotrack.cgi"
					},
				  "SYNO.VideoStation.Collection" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "VideoStation/collection.cgi"
					},
				  "SYNO.VideoStation.Folder" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "VideoStation/folder.cgi"
					},
				  "SYNO.VideoStation.HomeVideo" : { "maxVersion" : 3,
					  "minVersion" : 1,
					  "path" : "VideoStation/homevideo.cgi"
					},
				  "SYNO.VideoStation.Info" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/info.cgi"
					},
				  "SYNO.VideoStation.Library" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/library.cgi"
					},
				  "SYNO.VideoStation.Metadata" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "VideoStation/metadata.cgi"
					},
				  "SYNO.VideoStation.Misc" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/misc.cgi"
					},
				  "SYNO.VideoStation.Movie" : { "maxVersion" : 3,
					  "minVersion" : 1,
					  "path" : "VideoStation/movie.cgi"
					},
				  "SYNO.VideoStation.PluginSearch" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/pluginsearch.cgi"
					},
				  "SYNO.VideoStation.Poster" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/poster.cgi"
					},
				  "SYNO.VideoStation.Rating" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/rater.cgi"
					},
				  "SYNO.VideoStation.Sharing" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/sharing.cgi"
					},
				  "SYNO.VideoStation.Streaming" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/vtestreaming.cgi"
					},
				  "SYNO.VideoStation.Subtitle" : { "maxVersion" : 3,
					  "minVersion" : 1,
					  "path" : "VideoStation/subtitle.cgi"
					},
				  "SYNO.VideoStation.TVRecording" : { "maxVersion" : 3,
					  "minVersion" : 1,
					  "path" : "VideoStation/tvrecord.cgi"
					},
				  "SYNO.VideoStation.TVShow" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "VideoStation/tvshow.cgi"
					},
				  "SYNO.VideoStation.TVShowEpisode" : { "maxVersion" : 3,
					  "minVersion" : 1,
					  "path" : "VideoStation/tvshow_episode.cgi"
					},
				  "SYNO.VideoStation.Video" : { "maxVersion" : 2,
					  "minVersion" : 1,
					  "path" : "VideoStation/video.cgi"
					},
				  "SYNO.VideoStation.WatchStatus" : { "maxVersion" : 1,
					  "minVersion" : 1,
					  "path" : "VideoStation/watchstatus.cgi"
					}
				},
			  "success" : true
			}*/
			var additionalParams = new QueryStringParameter("query", "all");
			var url = GetApiUrl("query", 1, additionalParams);
			return Connection.GetDataFromUrl<object>(url);
		}
	}
}