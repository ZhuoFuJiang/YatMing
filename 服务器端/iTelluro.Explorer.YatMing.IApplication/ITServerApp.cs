using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.IApplication
{
    /// <summary>
    /// TServer基础方法接口
    /// </summary>
    public interface ITServerApp
    {
        /// <summary>
        /// 新增一条TServer记录
        /// </summary>
        /// <param name="dto">TServer实体</param>
        /// <returns>是否新增成功</returns>
        bool Add(TServerDTO dto);

        /// <summary>
        /// 根据主键删除一条TServer记录
        /// </summary>
        /// <param name="guid">TServer主键值</param>
        /// <returns>是否删除成功</returns>
        bool Remove(string guid);

        /// <summary>
        /// 更新一条TServer记录
        /// </summary>
        /// <param name="dto">TServer实体</param>
        /// <returns>是否更新成功</returns>
        bool Update(TServerDTO dto);

        /// <summary>
        /// 根据TServer主键获取一条记录
        /// </summary>
        /// <param name="guid">TServer主键值</param>
        /// <returns>根据主键查询到的TServer记录</returns>
        TServerDTO Get(string guid);

        /// <summary>
        /// 查询所有TServer记录
        /// </summary>
        /// <returns>TServer所有记录集合</returns>
        List<TServerDTO> GetAll();

    }
}
