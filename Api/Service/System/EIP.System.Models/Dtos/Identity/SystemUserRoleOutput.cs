﻿using System;
using EIP.Common.Entities.Dtos;

namespace EIP.System.Models.Dtos.Identity
{
    /// <summary>
    /// 用户角色Dto
    /// </summary>
    public class SystemUserRoleOutput : IOutputDto
    {
        /// <summary>
        /// 角色Id
        /// </summary>
        public Guid RoleId { get; set; }
        
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 归属组织机构
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// 是否已存在
        /// </summary>
        public bool Exist { get; set; }
    }
}