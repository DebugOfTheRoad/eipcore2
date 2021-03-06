using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EIP.System.Models.Entities
{
    /// <summary>
    /// System_Post表实体类
    /// </summary>
	[Serializable]
	[Table("System_Post")]
    public class SystemPost
    {
        /// <summary>
        /// 主键
        /// </summary>		
        [Key]
		public Guid PostId{ get; set; }
       
        /// <summary>
        /// 组织机构Id
        /// </summary>		
		public Guid OrganizationId{ get; set; }
     
        /// <summary>
        /// 组名称
        /// </summary>		
		public string Name{ get; set; }
       
        /// <summary>
        /// 状态
        /// </summary>		
		public short? State{ get; set; }
       
        /// <summary>
        /// 排序
        /// </summary>		
		public int  OrderNo { get; set; }=0;
       
        /// <summary>
        /// 备注
        /// </summary>		
		public string Remark{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>		
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 创建用户Id
        /// </summary>		
        public Guid CreateUserId { get; set; }

        /// <summary>
        /// 创建人员名称
        /// </summary>
        public string CreateUserName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>		
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 创建用户Id
        /// </summary>		
        public Guid? UpdateUserId { get; set; }

        /// <summary>
        /// 修改人员名称
        /// </summary>
        public string UpdateUserName { get; set; }
       
        /// <summary>
        /// 冻结
        /// </summary>		
		public bool IsFreeze{ get; set; }
   } 
}
