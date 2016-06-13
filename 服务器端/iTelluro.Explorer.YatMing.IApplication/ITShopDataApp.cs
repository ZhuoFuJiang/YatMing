using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.IApplication
{
    /// <summary>
    /// TShopData基础方法接口
    /// </summary>
    public interface ITShopDataApp
    {
        /// <summary>
        /// 新增一条TShopData记录
        /// </summary>
        /// <param name="dto">TShopData实体</param>
        /// <returns>是否新增成功</returns>
        bool Add(TShopDataDTO dto);

        /// <summary>
        /// 根据主键删除一条TShopData记录
        /// </summary>
        /// <param name="guid">TShopData主键值</param>
        /// <returns>是否删除成功</returns>
        bool Remove(string guid);

        /// <summary>
        /// 更新一条TShopData记录
        /// </summary>
        /// <param name="dto">TShopData实体</param>
        /// <returns>是否更新成功</returns>
        bool Update(TShopDataDTO dto);

        /// <summary>
        /// 根据TShopData主键获取一条记录
        /// </summary>
        /// <param name="guid">TShopData主键值</param>
        /// <returns>根据主键查询到的TShopData记录</returns>
        TShopDataDTO Get(string guid);

        /// <summary>
        /// 查询所有TShopData记录
        /// </summary>
        /// <returns>TShopData所有记录集合</returns>
        List<TShopDataDTO> GetAll();

    }
}
