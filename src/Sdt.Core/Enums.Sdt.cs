using System;

namespace Sdt
{
    //权限系统基础数据状态
    public enum SecurityCommonStatus
    {
        作废 = 0,
        有效 = 2
    }

    //权限系统企业状态
    public enum SecurityEnterpriseStatus
    {
        作废 = 0,
        新建 = 1,
        冻结 = 2,
        生效 = 3
    }

    //页面级别
    public enum SecurityPageType
    {
        系统 = 0,
        分组 = 1,
        页面 = 2
    }

    //组织类型
    public enum SecurityOrganizationOrganizationType
    {
        企业 = 0,
        部门 = 1
    }

    //节点类型
    public enum SecurityNodeCategoryType
    {
        页面 = 0,
        操作 = 1,
        数据列 = 2
    }

    //权限人员状态
    public enum SecurityUserStatus
    {
        作废 = 0,
        有效 = 1,
        冻结 = 2
    }

    //企业类型
    public enum SecurityEnterpriseType
    {
        EnterpriseType_4S店 = 0,
        EnterpriseType_二级网点 = 1
    }

    //当前环境所包含的系统类型
    [Flags]
    public enum SystemTypes
    {
        Dms = 0x1,
        Dcs = 0x2
    }

    //权限系统角色状态
    public enum SecurityRoleStatus
    {
        冻结 = 0,
        有效 = 1
    }

    public enum TenantCategory
    {
        Branch = 1,
        Dealer = 2,
        Agency = 3,
        LogisticCompany = 4,
        ResponsibleUnit = 5,
        PartsSupplier = 6,
        Manufacturer = 7,
        VehicleCarrier = 8,
        LogisticCustomer = 9
    }
}
