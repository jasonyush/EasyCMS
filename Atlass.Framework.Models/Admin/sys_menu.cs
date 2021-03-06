//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://www.freesql.net
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace Atlass.Framework.Models {

	
	public partial class sys_menu {


		[JsonProperty, Column(IsPrimary = true)]
		public long id { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string create_person { get; set; } = string.Empty;

		[JsonProperty]
		public DateTime create_time { get; set; }

		[JsonProperty, Column(DbType = "tinyint(1)")]
		public int iframe { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string menu_icon { get; set; } = string.Empty;

		[JsonProperty, Column(DbType = "tinyint(4)")]
		public int menu_level { get; set; }

		/// <summary>
		/// 菜单名称
		/// </summary>
		[JsonProperty, Column(StringLength = 50)]
		public string menu_name { get; set; } = string.Empty;
		/// <summary>
		/// 菜单排序
		/// </summary>
		[JsonProperty]
		public int menu_sort { get; set; }

		/// <summary>
		/// 目录还是菜单 0-目录，1-菜单
		/// </summary>
		[JsonProperty, Column(DbType = "tinyint(4)")]
		public int menu_type { get; set; }

		/// <summary>
		/// 菜单链接
		/// </summary>
		[JsonProperty, Column(StringLength = 50)]
		public string menu_url { get; set; } = string.Empty;
		/// <summary>
		/// 上级菜单
		/// </summary>
		[JsonProperty]
		public long parent_id { get; set; }

		/// <summary>
		/// 备注
		/// </summary>
		[JsonProperty, Column(StringLength = 50)]
		public string remark { get; set; } = string.Empty;

		/// <summary>
		/// 权限标识 admin:menu:view
		/// </summary>
		[JsonProperty, Column(StringLength = 50)]
		public string role_tag { get; set; } = string.Empty;

		/// <summary>
		/// 子菜单
		/// </summary>
		[Column(IsIgnore =true)]
		public List<sys_menu> children { get; set; } = new List<sys_menu>();
		[Column(IsIgnore = true)]
		public string tab_id { get; set; }
	}

}
