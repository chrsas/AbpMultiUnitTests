namespace Sdt
{
    //提交返回信息（异常内容）
    public enum DcsSubmitResultCode
    {
        异常 = 0,
        合理 = 1,
        不合理 = 2
    }

    //退网申请单审核类型
    public enum DcsCancellationAppApproveType
    {
        大区经理审核 = 1,
        大区总监审核 = 2,
        确认审核 = 3,
    }

    //流水号重置类型
    public enum DcsCodeTemplateResetType
    {
        无 = 0,
        日 = 1,
        月 = 2,
        年 = 3
    }

    //主数据状态
    public enum DcsMasterDataStatus
    {
        有效 = 1,
        停用 = 2,
        作废 = 99
    }

    //基础数据状态
    public enum DcsBaseDataStatus
    {
        有效 = 1,
        作废 = 99
    }

    //性别
    public enum DcsSexType
    {
        未填 = 0,
        男 = 1,
        女 = 2,
        未知 = 3
    }

    //区域类型
    public enum DcsRegionType
    {
        区 = 1,
        省 = 2,
        市 = 3,
        县_区 = 4,
        乡镇 = 5
    }

    //车辆状态
    public enum DcsVehicleStatus
    {
        总装上线 = 1,
        总装下线 = 2,
        生产入库 = 3,
        本部仓库 = 4,
        经销商在途 = 5,
        经销商仓库 = 6,
        实销完成 = 7,
        中转库在途 = 8,
        消耗领用 = 9,
        返回生产 = 10,
        游离 = 98,
        灭失 = 99
    }

    //用户类型
    public enum DcsCustomerType
    {
        个人用户 = 1,
        组织用户 = 2
    }

    //年薪
    public enum DcsCustomerIncome
    {
        _5万以下 = 1,
        _5_10万 = 2,
        _10_15万 = 3,
        _15_20万 = 4,
        _20_25万 = 5,
        _25_30万 = 6,
        _30_35万 = 7,
        _35万以上 = 8
    }

    //基础客户类型
    public enum DcsCustomerCustomerType
    {
        个人客户 = 1,
        企业客户 = 2
    }

    //企业类型
    public enum DcsCompanyType
    {
        分公司 = 1,
        经销商 = 2,
        代理库 = 3,
        物流公司 = 4,
        责任单位 = 5,
        配件供应商 = 6,
        生产单位 = 7,
        承运商 = 8,
        物流客户 = 9,
        承运商集团 = 10
    }

    //简单审核单据状态
    public enum DcsWorkflowOfSimpleApprovalStatus
    {
        新建 = 1,
        已审核 = 2,
        作废 = 99
    }

    //数据类型
    public enum DcsServiceActivityConditionDataType
    {
        日期 = 1,
        布尔 = 2,
        整数 = 3,
        字符 = 4
    }

    //保有客户状态
    public enum DcsRetainedCustomerStatus
    {
        有效 = 1,
        流失 = 99
    }

    //整车订单状态
    public enum DcsVehicleOrderStatus
    {
        作废 = 99,
        新建 = 1,
        提交 = 2,
        财务审核 = 7
    }

    //整车订单清单状态
    public enum DcsVehicleOrderDetailStatus
    {
        新建 = 1,
        已上传 = 2,
        已确认 = 3,
        完成 = 4,
        作废 = 99
    }

    //整车订单类型
    public enum DcsVehicleOrderOrderType
    {
        普通订单 = 21,
        紧急订单 = 22,
        周订单 = 1,
        移库订单 = 2,
        小品种订单 = 3,
        寄售订单 = 4,
        中转库冲账订单 = 5,
        寄售冲账订单 = 6,
        试乘试驾订单 = 7,
        降级车订单 = 8,
        增补订单 = 9,
        大客户订单 = 10,
        服务车订单 = 11,
        上市车订单 = 12,
        新能源订单 = 13,
        退货订单 = 14,
        转售订单 = 15,
        大客户冲账订单 = 16,
        大客户寄售订单 = 17,
        A类预留 = 18,
        B类预留 = 19,
        特殊订单 = 20,
        专用车 = 23
    }

    //整车订单变更单清单状态
    public enum DcsVehicleOrderChangeDetailStatus
    {
        新建 = 1,
        拒绝 = 2,
        已确认 = 3,
        完成 = 4
    }

    //匹配类型
    public enum DcsVehiclePreAllocationRefMatchedType
    {
        订单 = 1,
        库存 = 2
    }

    //预分车关联单状态
    public enum DcsVehiclePreAllocationRefStatus
    {
        未匹配 = 1,
        库存匹配 = 2,
        处理完成 = 3,
        作废 = 99
    }

    //整车生产计划状态
    public enum DcsProductionPlanStatus
    {
        接受 = 0,
        拒绝 = 1
    }

    //整车退货单状态
    public enum DcsVehicleReturnOrderStatus
    {
        新增 = 1,
        作废 = 99,
        提交 = 2,
        财务审核 = 3,
        退货确认 = 4,
        转售确认 = 5,
        处理完成 = 6,
        经销商已出库 = 7,
        退货入库 = 8
    }

    //整车发运单状态
    public enum DcsVehicleShippingOrderStatus
    {
        未发运 = 1,
        已发运 = 2,
        全部接车 = 3,
        部分接车 = 4,
        作废 = 99
    }

    //整车发运方式
    public enum DcsVehicleShippingMethod
    {
        空运 = 1,
        水运 = 2,
        人工驾送 = 3,
        自提 = 4,
        公路 = 5,
        公铁联运 = 6,
        水陆联运 = 7,
        铁路 = 8,
        板车 = 9
    }

    //接车状态
    public enum DcsVehicleShippingDetailVehicleReceptionStatus
    {
        未发运 = 0,
        未接车 = 1,
        已接车 = 2,
        作废 = 99
    }

    //整车发车审批单状态
    public enum DcsVehicleShipplanApprovalStatus
    {
        新增 = 1,
        作废 = 99,
        已登记 = 2,
        已确认 = 3,
        已出库 = 4,
        部分下达 = 5,
        全部下达 = 6
    }

    //整车发车审批单清单状态
    public enum DcsVehicleShipplanApprovalDetailStatus
    {
        新增 = 1,
        已下达 = 2,
        已出库 = 3,
        作废 = 99,
        已拣配 = 4
    }

    //可用资源质量状态
    public enum DcsVehicleAvailableResourceQualityStatus
    {
        合格 = 1,
        不合格 = 2
    }

    //可用资源锁定状态
    public enum DcsVehicleAvailableResourceLockStatus
    {
        未锁定 = 1,
        预分车锁定 = 2,
        审批单锁定 = 3
    }

    //单车跟踪表原单据类型
    public enum DcsVehicleTrackingFormSourceBillType
    {
        发车审批单 = 1,
        退货单 = 2
    }

    //单车跟踪状态
    public enum DcsVehicleTrackingFormStatus
    {
        在库 = 1,
        出库 = 2,
        经销商在库 = 3,
        经销商售出 = 4
    }

    //控制日期类型
    public enum DcsVehicleOrderChangePolicyShippingDateControl
    {
        计划发车日期 = 1,
        期望发车日期 = 2
    }

    //整车批发价格折扣等级清单价格计算方式
    public enum DcsVehPifaPriceDiscLevelDetailPriceCalculationMethod
    {
        批发价x加价率 = 1,
        批发价plus加价额 = 2,
        批发价x加价率plus加价额 = 3
    }

    //整车订货计划状态
    public enum DcsVehicleOrderPlanStatus
    {
        新建 = 1,
        激活 = 2,
        完成 = 3,
        提交 = 5,
        已按回复量转成订单 = 6,
        作废 = 99,
        审核通过 = 4,
        审核不通过 = 7,
        已拆分成周计划 = 8
    }

    //车辆类型
    public enum DcsVehicleInformationVehicleType
    {
        商品车 = 1,
        降级车 = 2
    }

    //经销商买卖单状态
    public enum DcsDealerTransactionBillStatus
    {
        新建 = 1,
        提交 = 2,
        已确认 = 3,
        已出库 = 4,
        已入库 = 5,
        作废 = 99
    }

    //整车价格变更申请单状态
    public enum DcsVehiclePriceChangeAppStatus
    {
        新建 = 1,
        有效 = 2,
        已执行 = 3,
        作废 = 99
    }

    //整车基础数据状态
    public enum DcsVehicleBaseDataStatus
    {
        有效 = 1
    }

    //整车发车审批单调整类型
    public enum DcsVehShipplanApprovalChangeRecAdjustmentType
    {
        可用资源调整 = 1,
        审批单调整 = 2
    }

    //整车仓库类型
    public enum DcsVehicleWarehouseType
    {
        中心库 = 1,
        中转库 = 2,
        虚拟库 = 3
    }

    //库存状态
    public enum DcsDealerVehicleStockInventoryStatus
    {
        在途 = 0,
        在库 = 1,
        出库 = 2
    }

    //PDI检查状态
    public enum DcsDealerVehicleStockPDIStatus
    {
        不合格 = 0,
        合格 = 1
    }

    //产生库存类型
    public enum DcsDealerVehicleStockSourceType
    {
        采购入库 = 0,
        退货入库 = 1,
        调拨入库 = 2,
        经销商买卖入库 = 3
    }

    //库存锁定状态
    public enum DcsVehicleStockLockStatus
    {
        未锁定 = 0,
        锁定 = 1
    }

    //经销商仓库类型
    public enum DcsDealerWarehouseType
    {
        整车仓库 = 1,
        配件仓库 = 2,
        旧件仓库 = 3
    }

    //经销商销售区域
    public enum DcsDealerRegionManagerAffiSalesRegion
    {
        东区 = 1,
        南区 = 2,
        西区 = 3,
        北区 = 4,
        中区 = 5
    }

    //凭证摘要
    public enum DcsVehiclePaymentBillCertificateSummary
    {
        整车款 = 1,
        维修款 = 2
    }

    //整车来款单状态
    public enum DcsVehiclePaymentBillStatus
    {
        新增 = 1,
        作废 = 99,
        有效 = 2,
        审核通过 = 3,
        审核不通过 = 4
    }

    //整车汇票状态
    public enum DcsVehicleAccountReceivableBillStatus
    {
        新增 = 1,
        作废 = 99,
        已接收 = 2,
        银行查询 = 3,
        审核通过 = 4,
        已入账 = 5,
        转出申请 = 6,
        转出审批 = 7,
        出纳付票 = 8
    }

    //整车应收票据类型
    public enum DcsVehicleAccountReceivableBillType
    {
        两方承兑汇票 = 1,
        三方承兑汇票 = 2,
        质押汇票 = 3,
        其它 = 4
    }

    //整车价格状态
    public enum DcsVehiclePriceStatus
    {
        新建 = 1,
        有效 = 2,
        作废 = 99
    }

    //账户可用性
    public enum DcsVehicleCustomerAccountAvailability
    {
        可用 = 1,
        不可用 = 2
    }

    //整车经销商账户冻结状态
    public enum DcsVehicleDLRAccountFreezeBillStatus
    {
        新增 = 1,
        有效 = 2,
        作废 = 99
    }

    //整车应收票据转出类型
    public enum DcsVehicleAccountReceivableBillTransferOutType
    {
        汇票转出 = 1,
        贴现 = 2
    }

    //整车经销商信用额度申请状态
    public enum DcsVehicleDealerCreditLimitAppStatus
    {
        新建 = 1,
        有效 = 2,
        已执行 = 3,
        失效 = 4,
        作废 = 99
    }

    //整车应收账业务类型
    public enum DcsVehicleCustAccountHisDetailBusinessType
    {
        整车来款 = 1,
        整车销售出库 = 2,
        整车销售退货 = 3,
        汇票贴息 = 4,
        其它 = 5
    }

    //客户证件类型
    public enum DcsCustomerIdDocumentType
    {
        居民身份证 = 1,
        军官证 = 2,
        港澳台海外地区证件 = 3,
        企业代码证 = 4
    }

    //签约地点
    public enum DcsRetailContractSigningLocation
    {
        店内 = 1,
        车展 = 2,
        其它 = 3
    }

    //业务领域
    public enum DcsBusinessDomain
    {
        整车 = 1,
        服务 = 2,
        配件 = 3
    }

    //多级审核起始状态
    public enum DcsMultiLevelAuditConfigInitialStatus
    {
        新建 = 1,
        提交 = 2,
        审核中 = 3,
        审核通过 = 4,
        审核不通过 = 5,
        作废 = 99
    }

    //经销商类型
    public enum DcsDealerType
    {
        一级经销商 = 1,
        二级经销商 = 2
    }

    //岗位类型
    public enum DcsDealerPostType
    {
        关键岗位 = 1,
        业务岗位 = 2,
        认证岗位 = 3,
        二网人员 = 4,
        一点五网人员 = 5
    }

    //岗位等级
    public enum DcsDealerEmployeePostPostGrade
    {
        _1级 = 1,
        _2级 = 2,
        _3级 = 3,
        _4级 = 4,
        无级别 = 5
    }

    //人员状态
    public enum DcsDealerEmployeeEmployeeStatus
    {
        新增 = 1,
        变更 = 2,
        离职 = 3,
        休假 = 4,
        在职 = 5
    }

    //人员变更申请类型
    public enum DcsDealerEmployeeChangeAppType
    {
        变更 = 1,
        离职 = 2,
        休假 = 3
    }

    //人员档案变更申请单状态
    public enum DcsDealerEmployeeChangeAppStatus
    {
        待审核 = 1,
        审核通过 = 2,
        审核不通过 = 3,
        作废 = 99
    }

    //退网申请单状态
    public enum DcsCancellationAppStatus
    {
        新建 = 1,
        大区经理审核通过 = 2,
        大区经理审核不通过 = 3,
        确认通过 = 4,
        确认不通过 = 5,
        终止 = 6,
        已邮寄文件 = 7,
        清算汇总至财务 = 8,
        部门处理中 = 9,
        业务部门处理完成 = 10,
        汇款单至财务 = 11,
        作废 = 99,
        大区总监审核通过 = 12,
        大区总监审核不通过 = 13,
        已下发业务部门 = 14,
        财务清算完成 = 15,
        汇款完成 = 16
    }

    //备案申请单状态
    public enum DcsFilingApplicationStatus
    {
        新建 = 1,
        已提交财务 = 2,
        处理完成 = 3,
        作废 = 99
    }

    //举报类型
    public enum DcsAppealApplicationAppealType
    {
        跨区销售 = 1,
        跨区展示 = 2,
        低价销售 = 3,
        跨区宣传 = 4
    }

    //举报申请主单状态
    public enum DcsAppealApplicationStatus
    {
        待审核 = 1,
        双方协商中 = 2,
        审核不通过 = 3,
        已提报财务 = 4,
        已撤诉 = 5,
        处理完毕 = 6,
        作废 = 99
    }

    //举报申请主单审核标记
    public enum DcsAppealApplicationApprovalMark
    {
        举报成立 = 1,
        举报资料不全 = 2,
        举报不成立 = 3
    }

    //举报申请清单类型
    public enum DcsAppealDealerListType
    {
        实销方 = 1,
        原始进货方 = 2
    }

    //公告类型
    public enum DcsAnnouncementBillType
    {
        通知 = 1,
        通报 = 2,
        其他 = 3,
        政策 = 4
    }

    //通知通报状态
    public enum DcsAnnouncementBillStatus
    {
        未发布 = 1,
        已关闭 = 2,
        已发布 = 3,
        作废 = 99
    }

    //文件信息表状态
    public enum DcsFileInformationStatus
    {
        生效 = 1,
        申请关闭 = 2,
        已关闭 = 3,
        作废 = 99,
        本部门处理 = 4,
        非本部门处理 = 5
    }

    //满意度评价
    public enum DcsFileInformationSatisfaction
    {
        满意 = 1,
        不满意 = 2,
        一般 = 3,
        非常满意 = 4,
        非常不满意 = 5
    }

    //预约申请单状态
    public enum DcsReservationApplicationStatus
    {
        新建 = 1,
        已确认 = 2,
        接受预约 = 3,
        取消预约 = 99
    }

    //传播方式状态
    public enum DcsPropagateMethodStatus
    {
        生效 = 2,
        作废 = 99
    }

    //活动立项单状态
    public enum DcsMarketEventProjectStatus
    {
        新建 = 1,
        已确认 = 2,
        已审核 = 3,
        驳回 = 4,
        作废 = 99
    }

    //活动计划单状态
    public enum DcsMarketEventPlanStatus
    {
        新建 = 1,
        生效 = 2,
        已分配 = 3,
        已确认 = 4,
        驳回 = 5,
        作废 = 99,
        已审核 = 6
    }

    //活动计划单结算方式
    public enum DcsMarketEventPlanSettlementMethod
    {
        返利 = 1,
        直投 = 2,
        费用 = 4
    }

    //活动计划单执行方式
    public enum DcsMarketEventPlanPerformWay
    {
        经销商执行 = 1,
        大区招仪标 = 2,
        公司直投 = 3
    }


    //物流透明化数据量
    public enum DcsVirtualLogisticsStateTransparencyCount
    {
        物流透明化数据量 = 2
    }


    //市场活动结果登记单状态
    public enum DcsMarketEventOutcomeRecordStatus
    {
        新建 = 1,
        提交 = 2,
        已确认 = 3,
        已登记 = 4,
        已审核 = 5,
        驳回 = 6,
        作废 = 99,
        大区已审核 = 7
    }

    //市场活动结果登记单结算方式
    public enum DcsMarketEventOutcomeRecordSettlementMethod
    {
        返利 = 1,
        直投 = 2,
        自费 = 3,
        返现 = 4
    }

    //活动结算单状态
    public enum DcsMarketEventSettlementStatus
    {
        新建 = 1,
        提交 = 2,
        已审核 = 3,
        驳回 = 4,
        返利 = 5,
        作废 = 99
    }

    //活动立项单发起对象
    public enum DcsMarketEventProjectSponsor
    {
        主机厂 = 1,
        大区 = 2,
        销售店 = 3
    }

    //活动计划单发起对象
    public enum DcsMarketEventPlanSponsor
    {
        主机厂 = 1,
        大区 = 2,
        销售店 = 3
    }

    //销售活动单发起对象
    public enum DcsMarketEventSponsor
    {
        主机厂 = 1,
        大区 = 2,
        销售店 = 3
    }

    //抱怨级别
    public enum DcsTaskAssignmentComplainLevel
    {
        一般抱怨 = 1,
        中级抱怨 = 2,
        强烈抱怨 = 3
    }

    //派工单结果
    public enum DcsTaskAssignmentResult
    {
        产品质量 = 1,
        技术能力 = 2,
        备件供应 = 3,
        服务过程 = 4,
        随车文件 = 5,
        销售过程 = 6,
        产品类 = 21,
        销售类 = 22,
        服务类 = 23,
        备件类 = 24,
        技术咨询 = 31,
        服务咨询 = 32,
        备品咨询 = 33,
        销售咨询 = 34
    }

    //服务级别
    public enum DcsTaskAssignmentServiceLevel
    {
        _24小时联系回复_3天闭环 = 1,
        _24小时联系回复_2天闭环 = 2,
        _24小时联系回复_1天闭环 = 3
    }

    //派工单状态
    public enum DcsTaskAssignmentStatus
    {
        未反馈 = 0,
        处理中 = 1,
        待审核 = 2,
        业务部门审核DCS不通过 = 3,
        业务部门申请闭环 = 4,
        客服回访审核不通过 = 5,
        已审核 = 6
    }

    //派工单业务类型
    public enum DcsTaskAssignmentBusinessType
    {
        报修 = 1,
        抱怨 = 2,
        表扬 = 3,
        咨询 = 4,
        建议 = 5,
        救援 = 6,
        潜客 = 7,
        催单 = 8,
        预约 = 9
    }

    //潜客级别
    public enum DcsSalesLeadProspectLevel
    {
        F = 0,
        FO = 1,
        A = 2,
        B = 3,
        C = 4,
        N = 5,
        S = 6,
        O = 7,
    }

    //潜客意向
    public enum DcsSalesLeadProspectIntention
    {
        高意向 = 1,
        低意向 = 2
    }

    //客户来源
    public enum DcsSalesLeadCustomerSource
    {
        新车订单 = 1,
        _400电话 = 2,
        置换订单 = 3,
        试驾订单 = 4,
        电话营销_400 = 5,
        社会化媒体_在线客服 = 6,
        社会化媒体_网络活动 = 7,
        电话营销_外呼 = 8,
        微商城 = 103016,
        汽车之家车商城 = 103017,
        车喇叭 = 103018,
        官网 = 103019
    }

    //销售线索状态
    public enum DcsSalesLeadStatus
    {
        新派单 = 1,
        处理中 = 2,
        无效 = 3,
        有效 = 4,
        潜客成交 = 5,
        潜客战败 = 6
    }

    //客户历史类别
    public enum DcsSalesLeadIntentionHistoryCategory
    {
        FO = 1,
        A = 2,
        B = 3,
        C = 4,
        N = 5,
        S = 6,
        O = 7,
        F = 8
    }

    //节能惠民标准状态
    public enum DcsEnergySavePromotionStandardStatus
    {
        生效 = 1,
        作废 = 99
    }

    //节能惠民申请单状态
    public enum DcsEnergySavePromotionAppStatus
    {
        新建 = 1,
        提交 = 2,
        已审核 = 3,
        驳回 = 4,
        待结算 = 5,
        已结算 = 6,
        作废 = 99
    }

    //节能惠民结算单状态
    public enum DcsEvergySavePromotionSettlementStatus
    {
        新建 = 1,
        提交 = 2,
        审核 = 3,
        驳回 = 4,
        作废 = 99
    }

    //市场活动登记单结算状态
    public enum DcsMarketEventOutcomeRecordSettlementStatus
    {
        未结算 = 1,
        待结算 = 2,
        部分结算 = 3,
        已结算 = 4
    }

    //活动项目类别
    public enum DcsMarketEventOutcomeDetailCategory
    {
        广宣 = 1,
        物料 = 2,
        促销费用 = 3,
        其他 = 4
    }

    //活动结算汇总单状态
    public enum DcsMarketEventSettlementSumStatus
    {
        新建 = 1,
        提交 = 2,
        审核 = 3,
        驳回 = 4,
        作废 = 99
    }

    //故障判别
    public enum DcsTaskAssignmentMalfunctionRecognition
    {
        产品质量原因 = 1,
        加装原因 = 2,
        客户操作原因 = 3,
        自然灾害 = 4,
        其他 = 5
    }

    //经销商人员单据状态
    public enum DcsDealerEmployeeStatus
    {
        待审核 = 1,
        审核通过 = 2,
        审核不通过 = 3,
        作废 = 99
    }

    //市场活动单状态
    public enum DcsMarketEventStatus
    {
        新建 = 1,
        生效 = 2
    }

    //销售计划种类
    public enum DcsPlanRulePlanCategory
    {
        月度 = 1,
        周度 = 2
    }

    //销售计划类型
    public enum DcsVehicleOrderPlanType
    {
        周度计划 = 1,
        移库计划 = 2,
        中转库冲销计划 = 3,
        小品种计划 = 4,
        大客户计划 = 5,
        大客户增补计划 = 6,
        备库计划 = 7,
        经销商月度计划 = 8,
        建储计划 = 9,
        本部月度计划 = 10,
        大客户备库计划 = 11
    }

    //销售计划变更类型
    public enum DcsPlanModificationRuleType
    {
        车型 = 1,
        型号 = 2,
        物料 = 3
    }

    //月度计划类型
    public enum DcsMonthlyPlanType
    {
        本部 = 1,
        经销商 = 2
    }

    //折扣类型
    public enum DcsVehPifaPriceDiscLevelType
    {
        产品折扣 = 1,
        经销商折扣 = 2
    }

    //客户主诉
    public enum DcsTaskAssignmentCustomerComplain
    {
        客户主诉 = 1,
        客户要求 = 2,
        此前处理情况 = 3,
        客服意见 = 4
    }

    //线索来源
    public enum DcsSalesLeadLeadSource
    {
        厂端下发 = 1,
        易车网 = 2,
        汽车之家 = 3,
        其他 = 4,
        终端录入 = 5,
        官网 = 6,
        爱卡 = 7,
        太平洋 = 8
    }

    //线索类型
    public enum DcsSalesLeadLeadType
    {
        订单线索 = 1,
        _400电话 = 2,
        置换车 = 3,
        试乘试驾 = 4
    }

    //发运方式
    public enum DcsVehicleCarrierShippingMethod
    {
        公路 = 1,
        水路 = 2,
        铁路 = 3,
        自提 = 4
    }

    //板车状态
    public enum DcsVehicleTransportDrayDrayStatus
    {
        空闲 = 1,
        维修 = 2,
        在运 = 3
    }

    //板车属性
    public enum DcsVehicleTransportDrayProperty
    {
        自有 = 1,
        外协 = 2
    }

    //板车车型
    public enum DcsVehicleTransportDrayModel
    {
        上双下单 = 1,
        双层双排 = 2,
        单层单排 = 3,
        双层单排 = 4,
        地跑 = 5,
        背驼 = 6
    }

    //司机属性
    public enum DcsDriverInfoProperty
    {
        主驾驶 = 1,
        副驾驶 = 2
    }

    //装运场地库存信息车辆状态
    public enum DcsVehicleCarrierAreaStockVehicleStatus
    {
        正常 = 1,
        质损 = 2
    }

    //装运场地库存信息状态
    public enum DcsVehicleCarrierAreaStockStatus
    {
        待发运 = 1,
        已发运 = 2,
        送修出库 = 3,
        待返库 = 4
    }

    //装运场地库存信息锁定单据类型
    public enum DcsVehicleCarrierAreaStockLockBillType
    {
        整车发运单 = 1,
        整车送修单 = 2,
        换车申请单 = 3
    }

    //装运场地库存信息源单据类型
    public enum DcsVehicleCarrierAreaStockSourceType
    {
        整车发车审批单 = 1
    }

    //客户收货地址信息数据来源
    public enum DcsCustomerReceivingAddressSourceType
    {
        系统导入 = 1,
        手工维护 = 2
    }

    //运输事故单状态
    public enum DcsTransportAccidentStatus
    {
        新建 = 1,
        生效 = 2,
        作废 = 99
    }

    //整车质损单报损方
    public enum DcsVehicleDamageDamageSubmitter
    {
        仓库 = 1,
        承运商 = 2
    }

    //整车质损单质损环节
    public enum DcsVehicleDamageDamagePart
    {
        在线检查 = 1,
        入库检查 = 2,
        库间维护 = 3,
        出库检查 = 4,
        发车检查 = 5
    }

    //整车送修单状态
    public enum DcsVehicleRepairSendStatus
    {
        新建 = 1,
        生效 = 2,
        部分出库 = 3,
        全部出库 = 4,
        部分入库 = 5,
        全部入库 = 6,
        作废 = 99
    }

    //整车送修单送修类型
    public enum DcsVehicleRepairSendType
    {
        生产线返工 = 1,
        整备中心整备 = 2
    }

    //整车送修单清单原锁定单据类型
    public enum DcsVehicleRepairSendDetailOriginalLockBillType
    {
        整车出库计划单 = 1,
        同城调拨单 = 2,
        特殊出库申请单 = 3
    }

    //整车送修单清单状态
    public enum DcsVehicleRepairSendDetailStatus
    {
        待出库 = 1,
        已出库 = 2,
        待入库 = 3,
        已入库 = 4
    }

    //库内车辆维护任务类型
    public enum DcsVehicleMaintainTaskType
    {
        电瓶拆线 = 1,
        一月检查 = 2,
        三月检查 = 3,
        六月检查 = 4,
        十二月检查 = 5,
        二月检查 = 6,
        四月检查 = 7,
        五月检查 = 8,
        九月检查 = 9
    }

    //合格证台帐信息状态
    public enum DcsCertificateRecordStatus
    {
        在库中 = 1,
        已出库 = 2,
        待扫描 = 3,
        经销商仓库 = 4,
        经销商出库 = 5,
        经销商寄售库存 = 6
    }

    //合格证发放方式
    public enum DcsVehicleShipplanApprovalCertificateDeliveryMethod
    {
        随车发放 = 1,
        邮寄金融公司驻点员 = 2,
        三方银票银行自取 = 3,
        邮寄经销商 = 4,
        不发放 = 5
    }

    //合格证邮寄信息状态
    public enum DcsCertificateMailingInfoStatus
    {
        有效 = 1,
        扫描完成 = 2,
        作废 = 99
    }

    //随车物品信息规则
    public enum DcsInVehicleItemInfoRule
    {
        VIN = 1,
        生产批次号 = 2,
        物料号 = 3
    }

    //商品车路损质损单单据类型
    public enum DcsCommercialVehicleDamageType
    {
        商品车运输质损单 = 1,
        商品车售前质量反馈单 = 2
    }

    //整车盘点单状态
    public enum DcsVehicleInventoryStatus
    {
        有效 = 1,
        完成 = 2,
        作废 = 99
    }

    //整车盘点类型
    public enum DcsVehicleInventoryType
    {
        日常盘点 = 1,
        公司级盘点 = 2
    }

    //移库任务单状态
    public enum DcsVehicleMaintainTaskStatus
    {
        有效 = 1,
        开始执行 = 2,
        执行完毕 = 3,
        作废 = 99
    }

    //特殊出库申请单类型
    public enum DcsVehSpecialOutboundAppType
    {
        消耗领用 = 1,
        返回生产 = 2
    }

    //整车驳运单状态
    public enum DcsVehicleTransportBillStatus
    {
        新建 = 1,
        驳运完成 = 2,
        作废 = 99
    }

    //整车出库计划申请方
    public enum DcsVehicleOutboundPlanApplicant
    {
        运输科 = 1,
        承运商 = 2,
        仓储科 = 3
    }

    //整车出库计划单状态
    public enum DcsVehicleOutboundPlanStatus
    {
        新建 = 1,
        未拣配 = 2,
        已拣配 = 3,
        备货完成 = 4,
        部分出库 = 5,
        全部出库 = 6,
        作废 = 99
    }

    //整车出库计划单出库类型
    public enum DcsVehicleOutboundPlanOutboundType
    {
        销售出库 = 1,
        异地调拨出库 = 2,
        寄售出库 = 3,
        同城调拨出库 = 11,
        送修出库 = 12,
        消耗领用 = 13,
        返回生产 = 14
    }

    //整车出库计划单源单据类型
    public enum DcsVehicleOutboundPlanSourceType
    {
        交货单 = 1,
        整车送修单 = 2,
        特殊出库申请单 = 3,
        同城调拨单 = 4
    }

    //整车出库计划单清单状态
    public enum DcsVehicleOutboundPlanDetailStatus
    {
        待拣配 = 1,
        已拣配 = 2,
        已备货 = 3,
        已出库 = 4,
        已取消 = 5,
        作废 = 99
    }

    //整车入库计划单状态
    public enum DcsVehicleInboundPlanStatus
    {
        新建 = 1,
        有效 = 2,
        部分入库 = 3,
        全部入库 = 4,
        作废 = 99
    }

    //整车入库计划单入库类型
    public enum DcsVehicleInboundPlanInboundType
    {
        下线入库 = 1,
        同城调拨入库 = 2,
        退货入库 = 3,
        送修入库 = 4,
        换车入库 = 5,
        降级车入库 = 11,
        异地调拨入库 = 12,
        取消交货入库 = 13,
        消耗领用冲销入库 = 14
    }

    //整车入库计划单源单据类型
    public enum DcsVehicleInboundPlanSourceType
    {
        整车退货单 = 1,
        同城调拨单 = 2,
        整车送修单 = 3,
        整车驳运单 = 4,
        换车申请单 = 5,
        整车发运单 = 6
    }

    //整车入库计划单清单状态
    public enum DcsVehicleInboundPlanDetailStatus
    {
        未入库 = 1,
        已入库 = 2,
        作废 = 99
    }

    //单车发运跟踪台账状态
    public enum DcsVehicleShippingTrackRecordStatus
    {
        待发运 = 1,
        已发运 = 2,
        已接车 = 3
    }

    //仓库所属方
    public enum DcsVehicleWarehouseBelongsTo
    {
        物流公司 = 1,
        经销商 = 2,
        承运商 = 3,
        改装厂 = 4
    }

    //库区类型
    public enum DcsVehicleWarehouseAreaType
    {
        库区 = 1,
        待发区 = 2,
        质损区 = 3,
        滚装区 = 4,
        降级区 = 5
    }

    //库位种类
    public enum DcsVehicleWarehouseStructureCategory
    {
        仓库 = 1,
        库区 = 2,
        库道 = 3,
        库位 = 4
    }

    //整车仓库内部结构信息使用状态
    public enum DcsVehicleWarehouseBinInUseStatus
    {
        空闲 = 1,
        占用 = 2
    }

    //整车仓库状态
    public enum DcsVehicleWarehouseStatus
    {
        有效 = 1,
        停用 = 2,
        作废 = 99
    }

    //入库PDI检查状态
    public enum DcsVehicleInformationPDIStatus
    {
        合格 = 1,
        不合格 = 2,
        未检查 = 3
    }

    //下线入库仓库分配表规则
    public enum DcsInboundWarehouseAllocationRule
    {
        销售车型 = 1,
        物料号 = 2
    }

    //整车库存状态
    public enum DcsVehicleStockInventoryStatus
    {
        在库中 = 1,
        已出库 = 2,
        调拨在途 = 3,
        送修出库 = 4
    }

    //中转库库存状态
    public enum DcsVehicleStockInventoryStatus1
    {
        在库中 = 1,
        移库中 = 2,
        调拨在途 = 3
    }

    //整车库存车辆状态
    public enum DcsVehicleStockVehicleStatus
    {
        正常 = 1,
        质损 = 2
    }

    //锁定单据类型
    public enum DcsVehicleStockLockBillType
    {
        整车出库计划单 = 1,
        整车送修单 = 2,
        预分车 = 3,
        特殊出库申请单 = 4,
        同城调拨单 = 5
    }

    //整车发车审批单源单据类型
    public enum DcsVehicleShipplanApprovalSourceType
    {
        正常订单 = 1,
        调拨单 = 2,
        寄售订单 = 3,
        转售订单 = 4,
        寄售冲账订单 = 5,
        特殊出库申请单 = 6
    }

    //经销商出入库计划状态
    public enum DcsDealerInboundOutboundPlanStatus
    {
        作废 = 0,
        新增 = 1,
        生效 = 2,
        部分完成 = 3,
        完成 = 4,
        强制完成 = 5
    }

    //经销商出入库计划清单状态
    public enum DcsDealerInboundOutboundPlanDetailStatus
    {
        未完成 = 0,
        完成 = 1
    }

    //经销商入库计划入库类型
    public enum DcsDealerInboundPlanWarehouseType
    {
        采购入库 = 0,
        退货入库 = 1,
        调拨入库 = 2,
        经销商买卖入库 = 3
    }

    //经销商出库计划出库类型
    public enum DcsDealerOutboundPlanDeliveryType
    {
        采购退货出库 = 0,
        零售出库 = 1,
        调拨出库 = 2,
        经销商买卖出库 = 3,
        批售出库 = 4
    }

    //经销商客户类型
    public enum DcsDealerOutboundPlanCustomerType
    {
        部门 = 0,
        经销商 = 1,
        仓库 = 2,
        供应商 = 3,
        客户 = 4
    }

    //待发运车辆分配规则类型
    public enum DcsVehicleAllocationRuleType
    {
        销售车型 = 1,
        运输路线 = 2
    }

    //经销商转账资金类型
    public enum DcsDealerTransferApplicationTransferCapitalType
    {
        自有资金 = 1,
        三方银票 = 2,
        经融贷款 = 3
    }

    //大客户信息状态
    public enum DcsKeyAccountStatus
    {
        新建 = 1,
        作废 = 99,
        已跟进 = 2,
        已成交 = 3,
        战败 = 4,
        初审通过 = 5,
        初审不通过 = 6,
        复审通过 = 7,
        复审不通过 = 8,
        终审通过 = 9,
        终审不通过 = 10
    }

    //大客户项目授权申请状态
    public enum DcsKAProjectWarrantAppStatus
    {
        新建 = 1,
        提交 = 2,
        初审通过 = 3,
        初审不通过 = 4,
        项目审核通过 = 5,
        项目审核不通过 = 6,
        复审通过 = 7,
        复审不通过 = 8,
        终审通过 = 9,
        作废 = 99
    }

    //大客户项目等级
    public enum DcsKeyAccountProjectLevel
    {
        A = 1,
        B = 2,
        C = 3
    }

    //大客户项目跟进结果
    public enum DcsKeyAccountProjectFollowResult
    {
        项目成交 = 1,
        流失关闭 = 2
    }

    //大客户核实方式
    public enum DcsKeyAccountProjectVerificationMethod
    {
        走访客户 = 1,
        走访经销商 = 2,
        电话核实 = 3,
        主观属实项目 = 4,
        客观属实项目 = 5
    }

    //大客户返利资料建议
    public enum DcsKeyAccountProjectRebateMaterialSuggestion
    {
        发票复印件 = 1,
        购销合同复印件 = 2,
        驾驶证复印件 = 3,
        营运车复印件 = 4,
        第三方银行付款凭证_集团采购10台及以上 = 5
    }

    //大客户项目关闭状态
    public enum DcsKeyAccountProjectClosureStatus
    {
        成交 = 1,
        流失 = 2,
        虚假 = 3
    }

    //大客户项目状态
    public enum DcsKeyAccountProjectStatus
    {
        新建 = 1,
        提交 = 2,
        科长审核通过 = 11,
        科长审核不通过 = 12,
        项目审核通过 = 13,
        项目审核不通过 = 14,
        部长终审通过 = 15,
        部长终审不通过 = 16,
        项目成交 = 9,
        流失关闭 = 10,
        作废 = 99
    }

    //大客户合同类型
    public enum DcsKeyAccountContractType
    {
        大客户 = 1,
        直销 = 2
    }

    //运输方式
    public enum DcsKeyAccountContractShippingMethod
    {
        以甲方物流方式决定 = 1,
        自提 = 2
    }

    //大客户合同状态
    public enum DcsKeyAccountContractStatus
    {
        新建 = 1,
        经销商确认 = 2,
        财务审核 = 3,
        合同终止 = 4,
        财务部分审核 = 5,
        提交 = 6,
        作废 = 99
    }

    //大客户合同清单状态
    public enum DcsKeyAccountContractDetailStatus
    {
        新建 = 1,
        财务审核 = 2,
        作废 = 99
    }


    //降级合同类型
    public enum DcsDegradedVehicleContractType
    {
        拍卖 = 1,
        专项报告购车 = 2,
        经销商购车 = 3,
        领导干部购车 = 4
    }

    //降级车合同状态
    public enum DcsDegradedVehicleContractStatus
    {
        新建 = 1,
        有效 = 2,
        财务部分确认 = 3,
        财务确认 = 4,
        作废 = 99
    }

    //降级车合同清单状态
    public enum DcsDegradedVehicleContractDetailStatus
    {
        新建 = 1,
        确认 = 2,
        作废 = 99
    }

    //返利申请状态
    public enum DcsVehicleRebateAppStatus
    {
        新建 = 1,
        审核通过 = 2,
        审核不通过 = 3,
        已确认 = 4,
        作废 = 99
    }

    //客户资料修改申请单状态
    public enum DcsCustomerChangeAppStatus
    {
        新建 = 1,
        提交 = 2,
        审核 = 3,
        驳回 = 4,
        作废 = 99
    }

    //客户收货地址客户类型
    public enum DcsCustomerReceivingAddressType
    {
        经销商 = 1,
        整车仓库 = 2,
        配件仓库 = 3,
        旧件仓库 = 4,
        承运商场地 = 5,
        客户 = 6
    }

    //运输路线发运方式
    public enum DcsTransportRouteShippingMethod
    {
        公路 = 1,
        水路 = 2,
        铁路 = 3,
        联运 = 4
    }

    //预分车紧急度
    public enum DcsVehiclePreAllocationRefUrgentGrade
    {
        非紧急 = 1,
        紧急 = 2
    }

    //预分车关联单状态QR
    public enum DcsVehiclePreAllocationRefStatusQR
    {
        新建 = 1,
        已分配资源 = 2,
        已分配资金 = 3,
        已上传 = 4,
        订单执行成功 = 5,
        订单执行失败 = 6,
        已扣款 = 7,
        预分车取消申请 = 8,
        作废 = 99
    }

    //发车审批单资金类型
    public enum DcsVehicleShipplanApprovalFundsType
    {
        自有资金 = 1,
        三方银票 = 2,
        金融贷款 = 3
    }

    //发车审批单客户类型
    public enum DcsVehicleShipplanApprovalCustomerType
    {
        经销商 = 1,
        客户 = 2
    }

    //整车发运清单状态
    public enum DcsVehicleShippingDetailStatus
    {
        未发运 = 1,
        已发运 = 2,
        作废 = 99
    }

    //整车订货计划清单状态
    public enum DcsVehicleOrderPlanDetailStatus
    {
        新建 = 1,
        已冲账 = 2,
        完成 = 3
    }

    //整车订货计划意向
    public enum DcsVehicleOrderPlanDetailIntention
    {
        客户订单 = 1,
        备库车辆 = 4,
        其他 = 5
    }

    //文件信息类型
    public enum DcsFileInformationType
    {
        往来文件 = 1,
        日常问题 = 2,
        满意度问题 = 3
    }

    //通讯组组织类型
    public enum DcsDistributionGroupDetailOrganizationType
    {
        组织 = 1,
        角色 = 2,
        所有人员 = 3
    }

    //通知通报组织类型
    public enum DcsAnnouncementBillDetailOrganizationType
    {
        组织 = 1,
        角色 = 2,
        通讯组 = 3,
        所有人员 = 4
    }

    //通知通报信息级别
    public enum DcsAnnouncementBillInformationLevel
    {
        紧急 = 1,
        不紧急 = 2,
        一般 = 3
    }

    //退网申请单类型
    public enum DcsCancellationAppType
    {
        网络部创建 = 1,
        经销商创建 = 2
    }

    //二网类型
    public enum DcsDealerSubNetworkType
    {
        直营店 = 1,
        合作二网 = 2
    }

    //实销付款方式
    public enum DcsVehicleProjectInformationPaymentMethod
    {
        一次性支付 = 0,
        分期支付 = 1
    }

    //经销商二网信息申请单状态
    public enum DcsSubDealerApplicationStatus
    {
        待审核 = 1,
        有效 = 2,
        审核不通过 = 3,
        停用 = 4,
        作废待审核 = 5,
        作废 = 99
    }

    //运费标准单状态
    public enum DcsTransportPriceStatus
    {
        新建 = 1,
        生效 = 2,
        作废 = 99
    }

    //运输路线状态
    public enum DcsTransportRouteStatus
    {
        新建 = 1,
        生效 = 2,
        作废 = 99
    }

    //是否特销
    public enum DcsVehicleProjectInformationIsSpecialSale
    {
        非特销车 = 1,
        出租 = 2,
        二手车 = 3,
        钢铁 = 4,
        公安 = 5,
        集团 = 6,
        驾校 = 7,
        教师 = 8,
        企业 = 9,
        医院 = 10,
        政府 = 11,
        租赁 = 12
    }

    //车辆性质
    public enum DcsVehicleProjectInformationVehicleProperty
    {
        三包车 = 1,
        公务_商务车 = 2,
        营运用车 = 3,
        非保修车 = 4,
        特殊保修车 = 5,
        家用_非三包车_ = 6,
        非营运用车 = 38
    }

    //购车年限
    public enum DcsVehicleProjectInformationOwningCarYears
    {
        一年以内 = 0,
        _1_3年 = 1,
        _3_5年 = 2,
        _5_10年 = 3,
        _10年以上 = 4,
        未知 = 5,
    }
    //购车年龄
    public enum DcsRetainedCustomerOwningCarAge
    {
        _20以下 = 0,
        _21_25 = 1,
        _26_30 = 2,
        _31_35 = 3,
        _36_40 = 4,
        _41_45 = 5,
        _45以上 = 6
    }

    //年龄区间
    public enum DcsCustomerAge
    {
        _20以下 = 1,
        _21_25 = 2,
        _26_30 = 3,
        _31_35 = 4,
        _36_40 = 5,
        _41_45 = 6,
        _45以上 = 7
    }

    //置换理由
    public enum DcsVehicleProjectInformationChangeReason
    {
        收购价高 = 1,
        过户便捷 = 2,
        熟人介绍 = 3,
        保险到期 = 4,
        有新车促销 = 5
    }

    //贷款渠道
    public enum DcsVehicleProjectInformationLendingChannel
    {
        金融公司 = 1,
        工行 = 2,
        建行 = 3,
        农行 = 4
    }

    //通知通报附件上传类型
    public enum DcsAnnouncementBillAttachmentType
    {
        点对点上传 = 1,
        单一上传 = 2,
        无需上传附件 = 3
    }

    //库间维护车辆明细库龄
    public enum DcsNeedsMaintainedVehicleWarehouseAge
    {
        _30天 = 30,
        _90天 = 90,
        _180天 = 180,
        _360天 = 360,
        _60天 = 60,
        _120天 = 120,
        _150天 = 150,
        _270天 = 270
    }

    //库位整理任务单
    public enum DcsWarehouseBinArrangeTaskStatus
    {
        有效 = 1,
        完成 = 2
    }

    //运营性质
    public enum DcsVehicleInformationOperationsNature
    {
        运营 = 1,
        非运营 = 2
    }

    //付款类型
    public enum DcsPotentialCustomerPayOutType
    {
        一次性支付 = 0,
        分期支付 = 1
    }

    //回访报告状态
    public enum DcsPotentialCustomerVisitReportStatus
    {
        失败 = 0,
        成功 = 1,
        跟踪 = 2,
        未提车 = 3,
        未回访 = 4
    }

    //回访方式
    public enum DcsReturnVisitTaskMode
    {
        电话 = 0,
        短信 = 1,
        传真 = 2,
        邮件 = 3,
        拜访 = 4,
        其他 = 5
    }

    //回访任务大类
    public enum DcsReturnVisitTaskTaskCategory
    {
        潜客跟进 = 0,
        客户维系 = 1
    }

    //回访任务单状态
    public enum DcsReturnVisitTaskStatus
    {
        作废 = 0,
        新建 = 1,
        处理中 = 2,
        回访完成 = 3,
        不再回访 = 4
    }

    //回访任务相关单据类型
    public enum DcsReturnVisitTaskLinkBillType
    {
        零售合同 = 0,
        维修合同 = 1,
        保险单 = 2,
        技术服务活动 = 3
    }

    ////客户确度
    //public enum DcsPotentialCustomerLevelOfIntent {
    //    O = 7
    //}

    //潜客跟进任务类型
    public enum DcsReturnVisitTaskPotentialCustomerTaskType
    {
        首次回访 = 0,
        周期性回访 = 1,
        售车回访 = 2
    }

    //客户维系任务类型
    public enum DcsReturnVisitTaskRetainedCustomerTaskType
    {
        普通保养提醒 = 0,
        首保提醒 = 1,
        保险提醒 = 2,
        年检提醒 = 3,
        维修回访 = 4,
        节日问候 = 5,
        纪念日问候 = 6,
        保修到期提醒 = 7,
        保险到期提醒 = 8,
        流失回访 = 9,
        服务活动提醒 = 10
    }

    //潜在客户状态
    public enum DcsPotentialCustomerStatus
    {
        作废 = 0,
        新增 = 1,
        已跟进 = 2,
        已成交 = 3,
        战败 = 4,
        被合并 = 5
    }

    //扩展信息模板类别
    public enum DcsExtendedInfoTemplateCategory
    {
        保有客户扩展信息 = 0,
        车型扩展信息 = 1,
        产品扩展信息 = 2,
        派工单扩展信息 = 3
    }

    //扩展信息模板数据类型
    public enum DcsExtendedInfoTemplateDataType
    {
        分类 = 0,
        问题 = 1,
        选项 = 2
    }

    //扩展信息模板问题类型
    public enum DcsExtendedInfoTemplateQuestionType
    {
        输入 = 0,
        单选 = 1,
        多选 = 2,
        长文本输入 = 3
    }

    //SAP销售渠道
    public enum DcsVehicleProjectInformationSAPSalesChannel
    {
        大客户 = 1,
        国内 = 2,
        国际 = 3,
        特殊 = 4
    }

    //合格证扫描结果
    public enum DcsCertificateInventoryDetailResult
    {
        存在 = 1,
        盘盈 = 2,
        盘亏 = 3
    }

    //整车冻结单类型
    public enum DcsVehicleFreezeType
    {
        冻结 = 1,
        解冻 = 2
    }

    //ERP盘点单状态
    public enum DcsERPVehicleInventoryStatus
    {
        有效 = 1,
        已执行 = 2
    }

    //VLS基础状态
    public enum DcsVLSBaseStatus
    {
        新建 = 1,
        生效 = 2,
        作废 = 99
    }

    //同城调拨单状态
    public enum DcsVehicleIntraCityTransferStatus
    {
        新建 = 1,
        审核通过 = 2,
        审核不通过 = 3,
        确认通过 = 4,
        确认不通过 = 5,
        作废 = 6
    }

    //承运商场地盘点结果
    public enum DcsCarrierAreaInventoryDetailResult
    {
        一致 = 1,
        盘盈 = 2,
        盘亏 = 3
    }

    //承运商场地盘点单状态
    public enum DcsCarrierAreaInventoryStatus
    {
        有效 = 1,
        完成 = 2,
        作废 = 99
    }

    //联系人类型
    public enum DcsVehicleContactPersonType
    {
        车主 = 1,
        亲友 = 2,
        同事 = 3,
        司机 = 4,
        随从 = 5,
        下属 = 6
    }

    //经销商转账类型
    public enum DcsDealerTransferApplicationType
    {
        经销商内部 = 1,
        经销商之间 = 2
    }

    //经销商转账申请状态
    public enum DcsDealerTransferApplicationStatus
    {
        新增 = 1,
        有效 = 2,
        审核通过 = 3,
        审核不通过 = 4,
        作废 = 99
    }

    //经销商月度销售目标状态
    public enum DcsDealerMonthlySalesTargetStatus
    {
        新增 = 1,
        提交 = 2,
        大区总监审核通过 = 3,
        大区总监审核不通过 = 4,
        销售支援部审核通过 = 5,
        销售支援部审核不通过 = 6,
        分管副总审核通过 = 7,
        分管副总审核不通过 = 8,
        总经理审核通过 = 9,
        总经理审核不通过 = 10,
        已变更 = 11,
        变更提交 = 12,
        销售支援部变更审核通过 = 13,
        销售支援部变更审核不通过 = 14,
        分管副总变更审核通过 = 15,
        分管副总变更审核不通过 = 16,
        锁定 = 17,
        作废 = 99
    }

    //整车退货类型
    public enum DcsVehicleReturnOrderType
    {
        销售退货 = 1,
        转售退货 = 2
    }

    //整车退货运输方式
    public enum DcsVehicleReturnOrderShippingMethod
    {
        物流运输 = 1,
        自提 = 2
    }

    //寄售类型
    public enum DcsVehicleProjectInformationConsignmentType
    {
        非寄售 = 1,
        寄售 = 2,
        寄售冲账完成 = 3
    }

    //整车零售合同状态
    public enum DcsRetailContractStatus
    {
        作废 = 0,
        新增 = 1,
        驳回 = 2,
        生效 = 3,
        已收订金 = 4,
        已付清 = 5,
        发车 = 6,
        退订 = 9
    }

    //问卷模板类别
    public enum DcsQuestionnaireTemplateCategory
    {
        运营类 = 0,
        服务类 = 1,
        满意度 = 2,
        产品类 = 3,
        销售类 = 4,
        其他 = 5
    }

    //问卷模板数据类型
    public enum DcsQuestionnaireTemplateDataType
    {
        问卷 = 0,
        问题分类 = 1,
        问题 = 2,
        选项 = 3
    }

    //问卷模板问题类型
    public enum DcsQuestionnaireTemplateQuestionType
    {
        扩展题 = 0,
        单选题 = 1,
        多选题 = 2,
        打分题 = 3
    }

    //单车发运跟踪台账源单据类型
    public enum DcsVehicleShippingTrackRecordSourceType
    {
        整车发车审批单 = 0
    }

    //问卷信息状态
    public enum DcsQuestionnaireStatus
    {
        待下发 = 0,
        已下发 = 1,
        已关闭 = 2,
        作废 = 99
    }

    //经销商问卷信息状态
    public enum DcsDealerQuestionnaireStatus
    {
        待下发 = 0,
        进行中 = 1,
        已完成 = 2,
        已结束 = 3
    }

    //问卷问题跟踪状态
    public enum DcsQuestionnaireQuestionTrackStatus
    {
        待处理 = 0,
        已处理 = 1,
        无需处理 = 2,
        申请关闭 = 3,
        已关闭 = 4,
        作废 = 99
    }

    //经销商返利台账更改类型
    public enum DcsDealerRebateAccoutSourceType
    {
        订单调整 = 1,
        DCS传输 = 2,
        手工调整 = 3
    }

    //产品状态
    public enum DcsProductStatus
    {
        有效 = 1,
        停用 = 2,
        作废申请 = 3,
        作废 = 99
    }

    //运费核算单状态
    public enum DcsTransportCostAccountingStatus
    {
        新建 = 1,
        一审通过 = 2,
        一审不通过 = 3,
        二审通过 = 4,
        二审不通过 = 5,
        财务审核通过 = 6,
        财务审核不通过 = 7,
        财务取消审核 = 8,
        作废 = 99
    }

    //特殊出库申请单移动类型
    public enum DcsVehSpecialOutboundAppSubType
    {
        培训领用 = 1,
        培训领用冲销 = 2,
        质量招回领用 = 3,
        质量招回领用冲销 = 4,
        工作车辆领用发料 = 5,
        工作车辆领用发料冲销 = 6,
        技术开发领用 = 7,
        技术开发领用冲销 = 8,
        职工福利领用 = 9,
        职工福利领用冲销 = 10,
        售后服务领用_整车 = 11,
        售后服务领用冲销_整车 = 12,
        捐赠领用 = 13,
        捐赠领用冲销 = 14,
        业务宣传领用 = 15
    }

    //兴趣爱好
    public enum DcsRetainedCustomerHobby
    {
        旅游 = 0,
        娱乐 = 1,
        研究 = 2,
        运动 = 3,
        游戏 = 4,
        冒险 = 5,
        收藏 = 6,
        音乐 = 7,
        泡吧 = 8,
        没时间顾及业余爱好 = 9,
        按摩 = 10,
        桑拿 = 11,
        参加俱乐部活动 = 12,
        看书_看报 = 13,
        上网浏览新闻 = 14,
        进修_学习 = 15,
        炒股_投资基金 = 16,
        打高尔夫 = 17,
        骑单车 = 18,
        打球 = 19,
        游泳 = 20,
        健身 = 21,
        钓鱼 = 22,
        上网打游戏 = 23,
        打麻将_打牌 = 24,
        爬山 = 25,
        攀岩 = 26,
        集邮 = 27,
        听音乐 = 28,
        没什么时间顾及业余爱好 = 29,
        其他 = 30
    }

    //整车发运单清单原始需求单据类型
    public enum DcsVehicleShippingDetailOriginalRequirementBillType
    {
        整车发车审批单 = 0,
        整车退货交货单 = 1
    }

    //所属系统
    public enum DcsMappingOwner
    {
        CRM = 1,
        易车网 = 2,
        车商汇 = 3
    }

    //产品选装类型
    public enum DcsRetailContractOptionalListType
    {
        精品件选装 = 0,
        配置选装 = 1
    }

    //问卷模板状态
    public enum DcsQuestionnaireTemplateStatus
    {
        未使用 = 0,
        已使用 = 1,
        作废 = 99
    }

    //整车质损单清单处理方式
    public enum DcsVehicleDamageDetailProcessMethod
    {
        生产线返工 = 1,
        整备中心整备 = 2,
        现场维修 = 3
    }

    //换车履历状态
    public enum DcsVehicleExchangeRecordStatus
    {
        有效 = 1,
        已返库 = 2
    }

    //整车退货交货单状态
    public enum DcsVehicleReturnDeliveryStatus
    {
        新建 = 1,
        作废 = 99
    }

    //整车退货交货单类型
    public enum DcsVehicleReturnDeliveryType
    {
        销售退货 = 1,
        转售退货 = 2
    }

    //整车退货交货单清单状态
    public enum DcsVehicleReturnDeliveryDetailStatus
    {
        新建 = 1,
        已下达 = 2,
        已入库 = 3,
        作废 = 99
    }

    //订单运输方式
    public enum DcsVehicleOrderDetailExtendShippingMethod
    {
        物流运输 = 1,
        自提 = 2
    }

    //货款支付方式
    public enum DcsRetailContractPaymentType
    {
        分期付款 = 0,
        现款 = 1,
        贷款 = 2
    }

    //结算状态
    public enum DcsRetailContractAccountSettleStatus
    {
        无需结算 = 0,
        待结算 = 1,
        已结算 = 2
    }

    //购车用途
    public enum DcsRetailContractAPPLICATION
    {
        家用 = 1,
        商用 = 2,
        家商兼用 = 3,
        出租_租赁_长途客运 = 4,
        长途客运 = 5,
        出租 = 6,
        驾校 = 7,
        接待用车 = 8,
        领导配车 = 9,
        业务用车 = 10,
        租赁 = 11,
        其他 = 12,
        个人代步 = 13,
        事业单位 = 14,
        公务 = 16,
        其他接待用车 = 17,
        军用 = 18,
        商务 = 19,
        商用为主兼顾家用 = 20,
        家用为主兼顾商用 = 21,
        样车 = 22,
        私家车 = 23,
        私用 = 24,
        经销 = 26,
        自用 = 27,
        试乘试驾车 = 28,
        //长途客运 = 29,
        //驾校 = 30,
        奖品 = 31,
        三包车 = 32,
        公务_商务车 = 33,
        营运用车 = 34,
        非保修车 = 35,
        特殊保修车 = 36,
        家用_非三包车 = 37
    }

    //经销商对账单方向
    public enum DcsDealerAcountCheckListDirection
    {
        借 = 1,
        贷 = 2
    }

    //月度计划清单状态
    public enum DcsMonthlyPlanDetailStatus
    {
        新增 = 1,
        完成 = 2
    }

    //经销商返利申请单清单状态
    public enum DcsVehicleRebateAppDetailStatus
    {
        新增 = 1,
        已确认 = 2
    }

    //经销商季度销售目标状态
    public enum DcsDealerQuaterlySalesTargetStatus
    {
        有效 = 1,
        已分解 = 2,
        作废 = 99
    }

    //CRM状态
    public enum DcsTaskAssignmentCRMStatus
    {
        处理中 = 2,
        审核不通过 = 94,
        回访 = 95,
        暂存 = 96,
        作废 = 98,
        完成 = 99
    }

    //分配状态
    public enum DcsPotentialCustomerBaseDistributeStatus
    {
        未分配 = 0,
        已分配 = 1
    }

    //ERP库存地点信息类型
    public enum DcsERPStorageLocationType
    {
        国际 = 1,
        大客户 = 2,
        降级车 = 3,
        其他 = 4
    }

    //现居住地
    public enum DcsRetainedCustomerCurrentAddress
    {
        城镇 = 1,
        农村 = 2
    }

    //婚姻状况
    public enum DcsCustomerIfMarried
    {
        已婚 = 1,
        未婚 = 2
    }

    //家庭状况
    public enum DcsCustomerFamily
    {
        一般 = 1,
        良好 = 2
    }

    //信息渠道
    public enum DcsVehicleProjectInformationInformationChannel
    {
        新闻_报纸 = 1,
        电视 = 2,
        电台 = 3,
        网络平台_车商汇 = 4,
        网络平台_车易通 = 5,
        搜狐网 = 6,
        新浪网 = 7,
        汽车之家网 = 8,
        易车网 = 9,
        太平洋汽车网 = 10,
        其他互联网 = 11,
        车展 = 12,
        巡展 = 13,
        朋友介绍 = 14,
        店头 = 15,
        路过 = 16,
        其他 = 17,
        老客户推荐 = 18,
        天猫 = 19,
        爱卡 = 20,
        抢车网 = 21,
        车讯网 = 22,
        京东 = 23,
        拍拍 = 24,
        微商城 = 103016,
        汽车之家车商城 = 103017,
        车喇叭 = 103018,
        官网 = 103019

    }

    //合格证发放方式订单类型
    public enum DcsCERTDeliveryMethodOrderType
    {
        正常订单 = 1,
        寄售冲账订单 = 2
    }

    //合格证发放方式客户类型
    public enum DcsCERTDeliveryMethodDetailDealerType
    {
        一网 = 1,
        二网 = 2
    }

    //车辆过户申请状态
    public enum DcsVehicleTransferApplyStatus
    {
        新建 = 1,
        有效 = 2,
        驳回 = 3,
        作废 = 99
    }

    //网络级别
    public enum DcsChannelGrade
    {
        一级 = 1,
        二级 = 2
    }

    //纳税人资格
    public enum DcsPartsSupplierTaxpayerKind
    {
        一般纳税人 = 1,
        小规模纳税人 = 2
    }

    //供应商类型
    public enum DcsPartsSupplierType
    {
        正式供应商 = 1,
        临时供应商 = 2
    }

    //配件类型
    public enum DcsSparePartPartType
    {
        总成件 = 1,
        配件 = 2,
        精品件 = 3,
        辅料 = 4
    }

    //损耗类型
    public enum DcsSparePartLossType
    {
        非常用件 = 1,
        常用件 = 2,
        易耗件 = 3,
        大总成 = 4
    }

    //配件ABC分类
    public enum DcsABCStrategyCategory
    {
        A = 1,
        B = 2,
        C = 3,
        D = 4,
        E = 5,
        F = 6,
        G = 7,
        H = 8
    }

    //配件替互换类型
    public enum DcsPartsReplacementReplacementType
    {
        替换 = 1,
        互换 = 2
    }

    //采购价格状态
    public enum DcsPartsPurchasePricingStatus
    {
        新增 = 1,
        生效 = 2,
        作废 = 99
    }

    //采购价格变更申请单状态
    public enum DcsPartsPurchasePricingChangeStatus
    {
        新增 = 1,
        生效 = 2,
        作废 = 99
    }

    //库区库位类型
    public enum DcsAreaKind
    {
        仓库 = 1,
        库区 = 2,
        库位 = 3
    }

    //库区用途
    public enum DcsAreaType
    {
        保管区 = 1,
        问题区 = 2,
        检验区 = 3
    }

    //存储策略
    public enum DcsStorageStrategy
    {
        定位存储 = 1,
        随机存储 = 2
    }

    //市场部业务类型
    public enum DcsMarketingDepartmentType
    {
        销售 = 1,
        服务 = 2
    }

    //故障现象分类类型
    public enum DcsMalfunctionCategoryCategoryGroup
    {
        总成件 = 1,
        分总成 = 2,
        配件 = 3
    }

    //税率
    public enum DcsTaxRate
    {
        TaxRate_17 = 1,
        TaxRate_13 = 2,
        TaxRate_6 = 3,
        TaxRate_3 = 4,
        TaxRate_多种_其他 = 5
    }

    //地址用途
    public enum DcsAddressUsage
    {
        接收商品车 = 1,
        接收配件 = 2,
        接收其他物资 = 3
    }

    //旧件返回政策
    public enum DcsPartsWarrantyTermReturnPolicy
    {
        自行处理 = 1,
        监督处理 = 2,
        返回本部 = 3
    }

    //配件保修类型
    public enum DcsPartsWarrantyTermPartsWarrantyType
    {
        装车件保修 = 1,
        更换件保修 = 2,
        销售件保修 = 3
    }

    //保修政策类型
    public enum DcsWarrantyPolicyCategory
    {
        标准保修 = 1,
        特殊保修 = 2,
        延保产品 = 3
    }

    //保养计费模式
    public enum DcsVehicleWarrantyTermBillingModel
    {
        固定金额 = 1,
        按实际发生收取 = 2
    }

    //服务适用范围
    public enum DcsWarrantyPolicyApplicationScope
    {
        部分车型 = 1,
        所有车型 = 2
    }

    //发运方
    public enum DcsUsedPartsShippingOrderDispatcher
    {
        经销商发运 = 1,
        厂方发运 = 2,
        第三方 = 3
    }

    //旧件发运单状态
    public enum DcsUsedPartsShippingOrderStatus
    {
        新增 = 1,
        已确认 = 2,
        作废 = 99
    }

    //旧件验收状态
    public enum DcsUsedPartsShippingDetailReceptionStatus
    {
        在途 = 1,
        已接收 = 2,
        未接收 = 3,
        罚没 = 4
    }

    //旧件物流损失清单状态
    public enum DcsUsedPartsLogisticLossDetailProcessStatus
    {
        丢失 = 1,
        未返回 = 2
    }

    //服务站旧件处理类型
    public enum DcsSsUsedPartsDisposalBillDisposalMethod
    {
        自行处理 = 1,
        监督处理 = 2
    }

    //服务站旧件处理单状态
    public enum DcsSsUsedPartsDisposalBillStatus
    {
        新增 = 1,
        生效 = 2,
        作废 = 99
    }

    //维修保养索赔单索赔类型
    public enum DcsRepairClaimBillClaimType
    {
        维修索赔 = 1,
        保养索赔 = 2,
        服务活动 = 3
    }

    //开票类型
    public enum DcsInvoiceType
    {
        增值税专用发票 = 1,
        增值税普通发票 = 2,
        其他 = 3
    }

    //维修工种
    public enum DcsRepairItemJobType
    {
        机修 = 1,
        钣金 = 2,
        喷漆 = 3,
        其他 = 4
    }

    //维修结算属性
    public enum DcsRepairItemSettlementProperty
    {
        索赔 = 1,
        免费保养 = 2,
        免费维修 = 3,
        自费 = 4
    }

    //旧件出库类型
    public enum DcsUsedPartsOutboundOrderOutboundType
    {
        调拨出库 = 1,
        旧件处理出库 = 2,
        清退供应商出库 = 3,
        借用出库 = 4,
        加工领料出库 = 5
    }

    //旧件入库类型
    public enum DcsUsedPartsInboundOrderInboundType
    {
        服务站返件入库 = 1,
        调拨入库 = 2,
        借用归还 = 3,
        加工入库 = 4
    }

    //旧件出库状态
    public enum DcsUsedPartsOutboundStatus
    {
        待出库 = 1,
        部分出库 = 2,
        出库完成 = 3,
        终止出库 = 4
    }

    //旧件入库状态
    public enum DcsUsedPartsInboundStatus
    {
        待入库 = 1,
        部分入库 = 2,
        入库完成 = 3,
        终止入库 = 4
    }

    //旧件处理单状态
    public enum DcsUsedPartsDisposalBillStatus
    {
        新建 = 1,
        生效 = 2,
        作废 = 99
    }

    //旧件调拨单状态
    public enum DcsUsedPartsTransferOrderStatus
    {
        新建 = 1,
        生效 = 2,
        作废 = 99
    }

    //旧件加工单状态
    public enum DcsUsedPartsRefitBillStatus
    {
        新建 = 1,
        生效 = 2,
        作废 = 99
    }

    //旧件借用单状态
    public enum DcsUsedPartsLoanBillStatus
    {
        新建 = 1,
        生效 = 2,
        作废 = 99
    }

    //旧件移库单状态
    public enum DcsUsedPartsShiftOrderStatus
    {
        生效 = 1
    }

    //索赔单类型
    public enum DcsClaimBillType
    {
        维修索赔 = 1,
        保养索赔 = 2,
        服务活动索赔 = 3,
        配件索赔 = 4
    }

    //产品生命周期
    public enum DcsPartsBranchProductLifeCycle
    {
        新产品 = 1,
        正常产品 = 2,
        淘汰产品 = 3
    }

    //层次结构用途类型
    public enum DcsLayerStructurePurposePurposeType
    {
        维修项目分类 = 1,
        故障项目分类 = 2,
        产品分类 = 3
    }

    //服务活动适用范围
    public enum DcsServiceActivityApplicationScope
    {
        指定车辆清单 = 1,
        指定车辆条件 = 2
    }

    //价格类型
    public enum DcsPartsSalesPricePriceType
    {
        基准销售价 = 1,
        全国统一价 = 2
    }

    //配件销售价状态
    public enum DcsPartsSalesPriceStatus
    {
        新建 = 1,
        生效 = 2,
        作废 = 99
    }

    //采购订单状态
    public enum DcsPartsPurchaseOrderStatus
    {
        新增 = 1,
        提交 = 2,
        供应商确认 = 3,
        部分发运 = 4,
        发运完毕 = 5,
        终止 = 6,
        作废 = 99
    }

    //供应商发运单状态
    public enum DcsSupplierShippingOrderStatus
    {
        新建 = 1,
        收货确认 = 2,
        作废 = 99
    }

    //服务活动计费模式
    public enum DcsServiceActivityBillingMethod
    {
        固定费用 = 1,
        固定维修项目 = 2,
        按实际发生收取 = 3
    }

    //核算领域
    public enum DcsAccountGroupAccountType
    {
        配件销售 = 1,
        整车销售 = 2
    }

    //票据类型
    public enum DcsAccountReceivableBillType
    {
        商业承兑汇票 = 1,
        银行承兑汇票 = 2
    }

    //使用条件
    public enum DcsCredenceApplicationApplyCondition
    {
        合同范围内使用 = 1,
        自由支配使用 = 2
    }

    //运算符
    public enum DcsServiceActivityConditionMathOperator
    {
        大于 = 1,
        大于等于 = 2,
        等于 = 3,
        小于 = 4,
        小于等于 = 5
    }

    //摘要用途
    public enum DcsSummaryPurpose
    {
        收款 = 1,
        收款转账 = 2,
        付款 = 3,
        付款转账 = 4
    }

    //来款单状态
    public enum DcsPaymentBillStatus
    {
        新建 = 1,
        已审核 = 2,
        已分割 = 3,
        审核通过 = 4,
        审核不通过 = 5,
        作废 = 99
    }

    //采购订单类型
    public enum DcsPartsPurchaseOrderOrderType
    {
        月度采购订单 = 1,
        周度采购订单 = 2,
        紧急采购订单 = 3,
        专项采购订单 = 4
    }

    //应收票据状态
    public enum DcsAccountReceivableBillStatus
    {
        新增 = 1,
        已审核 = 2,
        已贴现 = 3,
        已背书转让 = 4,
        已兑现 = 5,
        作废 = 99
    }

    //付款方式
    public enum DcsPayOutBillPaymentMethod
    {
        分期付款 = 1,
        一次付清 = 2
    }

    //配件仓库类型
    public enum DcsWarehouseType
    {
        总库 = 1,
        分库 = 2,
        虚拟库 = 99
    }

    //物流公司业务领域
    public enum DcsLogisticCompanyBusinessDomain
    {
        配件发运 = 1,
        旧件返回 = 2,
        整车发运 = 3
    }

    //外出服务索赔单状态
    public enum DcsServiceTripClaimBillStatus
    {
        新增 = 1,
        提交 = 2,
        生效 = 3,
        已向责任单位索赔 = 4,
        已向责任供应商索赔 = 5,
        作废 = 99
    }

    //扣补款单状态
    public enum DcsExpenseAdjustmentBillStatus
    {
        新增 = 1,
        生效 = 2,
        已向责任单位索赔 = 3,
        已向责任供应商索赔 = 4,
        作废 = 99
    }

    //扣补款类型
    public enum DcsExpenseAdjustmentBillTransactionCategory
    {
        工时费 = 1,
        材料费 = 2,
        拖车费 = 3,
        批量质量信誉索赔费 = 4,
        旧件运输费 = 5,
        质量事故费 = 6,
        奖罚费 = 7,
        其他 = 8
    }

    //扣补款源单据类型
    public enum DcsExpenseAdjustmentBillSourceType
    {
        维修索赔 = 1,
        保养索赔 = 2,
        服务活动索赔 = 3,
        配件索赔 = 4,
        外出服务索赔 = 5
    }

    //维修索赔单单据状态
    public enum DcsRepairClaimBillRepairClaimStatus
    {
        新增 = 1,
        提交 = 2,
        生效 = 3,
        已向责任单位索赔 = 4,
        已向责任供应商索赔 = 5,
        作废 = 99
    }

    //保养索赔单单据状态
    public enum DcsRepairClaimBillMaintClaimStatus
    {
        新增 = 1,
        提交 = 2,
        生效 = 3,
        已向责任单位索赔 = 4,
        作废 = 99
    }

    //服务活动索赔单单据状态
    public enum DcsRepairClaimBillServiceActivityStatus
    {
        新增 = 1,
        提交 = 2,
        生效 = 3,
        已向责任单位索赔 = 4,
        作废 = 99
    }

    //配件索赔单单据状态
    public enum DcsPartsClaimBillStatus
    {
        新增 = 1,
        提交 = 2,
        生效 = 3,
        已向责任单位索赔 = 4,
        已向责任供应商索赔 = 5,
        作废 = 99
    }

    //索赔单结算状态
    public enum DcsClaimBillSettlementStatus
    {
        不结算 = 1,
        待结算 = 2,
        已结算 = 3
    }

    //申请单单据状态
    public enum DcsApplicationBillStatus
    {
        新增 = 1,
        提交 = 2,
        初审通过 = 3,
        生效 = 4,
        作废 = 99
    }

    //索赔单供应商确认状态
    public enum DcsRepairClaimBillSupplierConfirmStatus
    {
        未确认 = 1,
        确认已通过 = 2,
        确认未通过 = 3
    }

    //索赔单旧件处理状态
    public enum DcsRepairClaimBillUsedPartsDisposalStatus
    {
        旧件未全部到达 = 1,
        旧件全部到达 = 2
    }

    //索赔单维修项目清单状态
    public enum DcsRepairClaimItemDetailApproveStatus
    {
        未审核 = 0,
        审核通过 = 1,
        审核未通过 = 2
    }

    //索赔单维修材料清单旧件处理状态
    public enum DcsRepairClaimMaterialDetailUsedPartsDisposalStatus
    {
        未发运 = 1,
        已发运 = 2,
        已到达 = 3,
        不再发运 = 4
    }

    //维修申请类型
    public enum DcsRepairClaimApplicationRepairApplicationType
    {
        重大索赔 = 1,
        商品车维修 = 2,
        让度服务 = 3,
        更换总成及典型故障件索赔 = 4
    }

    //保养申请类型
    public enum DcsRepairClaimApplicationMaintApplicationType
    {
        商品车保养 = 1,
        过期让度 = 2,
        额外让度 = 3
    }

    //扣补款企业类型
    public enum DcsExpenseAdjustmentBillCompanyType
    {
        服务站 = 1,
        供应商 = 2
    }

    //扣补款方向
    public enum DcsExpenseAdjustmentBillDebitOrReplenish
    {
        扣款 = 1,
        补款 = 2
    }

    //售出状态
    public enum DcsVehicleInformationSalesStatus
    {
        未售出 = 1,
        已售出 = 2
    }

    //配件索赔类型
    public enum DcsPartsClaimOrderClaimType
    {
        更换件索赔 = 1,
        销售件索赔 = 2
    }

    //采购退货原因
    public enum DcsPartsPurReturnOrderReturnReason
    {
        质量件退货 = 1,
        积压件退货 = 2
    }

    //原始需求单据类型
    public enum DcsOriginalRequirementBillType
    {
        配件销售订单 = 1,
        配件销售退货单 = 2,
        积压件调剂单 = 3,
        配件采购订单 = 4,
        配件采购退货单 = 5,
        配件调拨单 = 6,
        内部领入单 = 7,
        内部领出单 = 8,
        配件零售订单 = 9,
        配件零售退货单 = 10
    }

    //应收账业务类型
    public enum DcsAccountPaymentBusinessType
    {
        销售出库计划 = 1,
        销售出库 = 2,
        销售退货入库 = 3,
        销售结算 = 4,
        作废销售结算 = 5,
        销售反结算 = 6,
        终止销售出库计划 = 7,
        直供订单预扣款 = 8,
        积压件调剂预扣款 = 9,
        来款 = 10,
        三包费转配件款 = 11,
        开户 = 12,
        注销 = 13
    }

    //应付帐业务类型
    public enum DcsAccountPayOutBusinessType
    {
        开户 = 1,
        注销 = 2,
        采购结算 = 3,
        采购退货结算 = 4,
        付款 = 5
    }

    //配件结算状态
    public enum DcsPartsSettlementStatus
    {
        不结算 = 1,
        待结算 = 2,
        已结算 = 3
    }

    //积压件申请单状态
    public enum DcsOverstockPartsAppStatus
    {
        新建 = 1,
        已提交 = 2,
        已审批 = 3,
        作废 = 99
    }

    //积压件调剂单状态
    public enum DcsOverstockPartsAdjustBillStatus
    {
        新建 = 1,
        生效 = 2,
        确认 = 3,
        完成 = 4,
        终止 = 5,
        作废 = 99
    }

    //配件入库检验单状态
    public enum DcsPartsInboundCheckBillStatus
    {
        新建 = 1,
        包装完成 = 2,
        上架完成 = 3
    }

    //配件入库类型
    public enum DcsPartsInboundType
    {
        配件采购 = 1,
        销售退货 = 2,
        配件调拨 = 3,
        内部领入 = 4,
        配件零售退货 = 5,
        积压件调剂 = 6
    }

    //配件入库计划状态
    public enum DcsPartsInboundPlanStatus
    {
        新建 = 1,
        检验完成 = 2,
        终止 = 3
    }

    //配件出库类型
    public enum DcsPartsOutboundType
    {
        配件销售 = 1,
        采购退货 = 2,
        配件调拨 = 3,
        内部领出 = 4,
        配件零售 = 5,
        积压件调剂 = 6
    }

    //配件出库计划状态
    public enum DcsPartsOutboundPlanStatus
    {
        新建 = 1,
        部分出库 = 2,
        出库完成 = 3,
        终止 = 4
    }

    //配件在途状态
    public enum DcsPartsLogisticBatchShippingStatus
    {
        待运 = 1,
        发运 = 2,
        供应商发运 = 3
    }

    //配件批次看板单据类型
    public enum DcsPartsLogisticBatchBillDetailBillType
    {
        配件出库单 = 1,
        配件发运单 = 2,
        供应商发运单 = 3,
        配件入库计划 = 4,
        配件入库检验单 = 5
    }

    //配件批次看板状态
    public enum DcsPartsLogisticBatchStatus
    {
        新增 = 1,
        完成 = 2
    }

    //配件盘点单状态
    public enum DcsPartsInventoryBillStatus
    {
        新建 = 1,
        已结果录入 = 2,
        已库存覆盖 = 3,
        作废 = 99
    }

    //配件移库单状态
    public enum DcsPartsShiftOrderStatus
    {
        生效 = 1
    }

    //配件移库类型
    public enum DcsPartsShiftOrderType
    {
        上架 = 1,
        移库 = 2
    }

    //配件调拨单状态
    public enum DcsPartsTransferOrderStatus
    {
        新建 = 1,
        已审批 = 2,
        作废 = 99
    }

    //配件调拨类型
    public enum DcsPartsTransferOrderType
    {
        月度需求调拨 = 1,
        周度需求调拨 = 2,
        紧急需求调拨 = 3
    }

    //配件发运单状态
    public enum DcsPartsShippingOrderStatus
    {
        新建 = 1,
        收货确认 = 2,
        回执确认 = 3,
        作废 = 99
    }

    //计划价申请单状态
    public enum DcsPlannedPriceAppStatus
    {
        新增 = 1,
        已审核 = 2,
        已执行 = 3,
        作废 = 99
    }

    //计账状态
    public enum DcsRecordStatus
    {
        不需要计账 = 1,
        未计账 = 2,
        已计账 = 3
    }

    //销售订单状态
    public enum DcsPartsSalesOrderStatus
    {
        新增 = 1,
        提交 = 2,
        撤单 = 3,
        部分审批 = 4,
        审批完成 = 5,
        终止 = 6,
        作废 = 99
    }

    //信用申请单状态
    public enum DcsCredenceApplicationStatus
    {
        新增 = 1,
        已审批 = 2,
        有效 = 3,
        失效 = 4,
        作废 = 99
    }

    //服务站索赔结算源单据类型
    public enum DcsSsClaimSettlementDetailSourceType
    {
        维修索赔单 = 1,
        保养索赔单 = 2,
        服务活动索赔单 = 3,
        配件索赔单 = 4,
        外出服务索赔单 = 5,
        扣补款单 = 6
    }

    //服务站索赔结算单状态
    public enum DcsSsClaimSettlementBillStatus
    {
        新增 = 1,
        已审批 = 2,
        发票登记 = 3,
        费用兑现 = 4,
        作废 = 99
    }

    //索赔结算指令状态
    public enum DcsSsClaimSettleInstructionStatus
    {
        有效 = 1,
        执行成功 = 2,
        执行失败 = 3,
        作废 = 99
    }

    //配件销售退货单状态
    public enum DcsPartsSalesReturnBillStatus
    {
        新增 = 1,
        提交 = 2,
        审批完成 = 3,
        作废 = 99
    }

    //配件销售退货开票要求
    public enum DcsPartsSalesReturnBillInvoiceRequirement
    {
        出库合并开票 = 1,
        反开销售发票 = 2,
        开红字发票 = 3
    }

    //配件销售退货单退货类型
    public enum DcsPartsSalesReturnBillReturnType
    {
        问题件退货 = 1,
        积压件退货 = 2,
        积压件调剂退货 = 3
    }

    //配件零售订单状态
    public enum DcsPartsRetailOrderStatus
    {
        新建 = 1,
        审批 = 2,
        开票 = 3,
        作废 = 99
    }

    //配件零售退货单状态
    public enum DcsPartsRetailReturnBillStatus
    {
        新建 = 1,
        审批 = 2,
        退款 = 3,
        作废 = 99
    }

    //订单处理方式
    public enum DcsPartsSalesOrderProcessDetailProcessMethod
    {
        未处理 = 1,
        本部处理 = 2,
        积压件平台 = 3,
        供应商直发 = 4
    }

    //配件发运单类型
    public enum DcsPartsShippingOrderType
    {
        销售 = 1,
        退货 = 2,
        调剂 = 3,
        调拨 = 4
    }

    //配件采购结算单状态
    public enum DcsPartsPurchaseSettleStatus
    {
        新建 = 1,
        已审批 = 2,
        发票登记 = 3,
        已反冲 = 4,
        作废 = 99
    }

    //结算方向
    public enum DcsPartsPurchaseSettleBillSettlementPath
    {
        正常结算 = 1,
        反冲结算 = 2
    }

    //开票方向
    public enum DcsPartsPurchaseRtnSettleBillInvoicePath
    {
        开红字发票 = 1,
        反开销售发票 = 2
    }

    //配件采购结算关联单据类型
    public enum DcsPartsPurchaseSettleRefSourceType
    {
        配件入库检验单 = 5,
        配件出库单 = 1
    }

    //配件来款方式
    public enum DcsPaymentBillPaymentMethod
    {
        服务费 = 7
    }

    //发票源单据类型
    public enum DcsInvoiceInformationSourceType
    {
        配件销售结算单 = 1,
        配件销售退货结算单 = 2,
        配件采购结算单 = 3,
        配件采购退货结算单 = 4,
        服务站索赔结算单 = 5
    }

    //订单处理状态
    public enum DcsPartsSalesOrderProcessDetailOrderProcessStatus
    {
        满足 = 1,
        未满足 = 2
    }

    //配件销售结算单状态
    public enum DcsPartsSalesSettlementStatus
    {
        新建 = 1,
        已审批 = 2,
        发票登记 = 3,
        已反冲 = 4,
        作废 = 99
    }

    //配件销售结算关联单据类型
    public enum DcsPartsSalesSettlementRefSourceType
    {
        配件出库单 = 1,
        配件入库检验单 = 5
    }

    //配件销售退货结算单状态
    public enum DcsPartsSalesRtnSettlementStatus
    {
        新建 = 1,
        已审批 = 2,
        发票登记 = 3,
        已反冲 = 4,
        作废 = 99
    }

    //发票类型
    public enum DcsInvoiceInformationType
    {
        增值税发票 = 1,
        服务发票 = 2,
        交通运输发票 = 3
    }

    //发票用途
    public enum DcsInvoiceInformationInvoicePurpose
    {
        整车销售 = 1,
        配件采购 = 2,
        配件销售 = 3,
        三包费用 = 4
    }

    //发票状态
    public enum DcsInvoiceInformationStatus
    {
        待开票 = 1,
        已开票 = 2,
        作废 = 99
    }

    //配件物流源单据类型
    public enum DcsPartsLogisticBatchSourceType
    {
        配件出库计划 = 1,
        配件采购订单 = 2
    }

    //配件销售结算返利方式
    public enum DcsPartsSalesSettlementRebateMethod
    {
        直接折扣 = 1,
        返利池 = 2
    }

    //配件返利源单据类型
    public enum DcsPartsRebateChangeDetailSourceType
    {
        返利申请单 = 1,
        销售结算单 = 2
    }

    //旧件清退单状态
    public enum DcsUsedPartsReturnOrderStatus
    {
        新建 = 1,
        已审批 = 2,
        作废 = 99
    }

    //旧件清退类型
    public enum DcsUsedPartsReturnOrderReturnType
    {
        清退责任单位 = 1,
        清退配件供应商 = 2,
        内部部门 = 3
    }

    //配件领用结算单状态
    public enum DcsPartsRequisitionSettleBillStatus
    {
        新建 = 1,
        已审批 = 2,
        作废 = 99
    }

    //配件领用结算关联单据类型
    public enum DcsPartsRequisitionSettleRefSourceType
    {
        配件出库单 = 1,
        配件入库检验单 = 5
    }

    //组织状态
    public enum DcsOrganizationStatus
    {
        作废 = 0,
        有效 = 2
    }

    //组织类型
    public enum DcsOrganizationOrganizationType
    {
        企业 = 0,
        部门 = 1
    }

    //权限角色状态
    public enum DcsRoleStatus
    {
        冻结 = 0,
        有效 = 1
    }

    //权限系统基础数据状态
    public enum DcsSecurityCommonStatus
    {
        作废 = 0,
        有效 = 2
    }

    //购车经历
    public enum DcsSalesLeadPurchaseHistory
    {
        第一次购车 = 1,
        替代原车_非奇瑞老客户 = 2,
        替代原车_奇瑞老客户 = 3,
        增购车_非奇瑞老客户 = 4,
        增购车_奇瑞老客户 = 5
    }

    //合同类型
    public enum DcsVehicleProjectInformationContractType
    {
        直销 = 1,
        租赁 = 2,
        集团 = 3,
        出租 = 4,
        政府 = 5,
        零售 = 6,
        黑出租 = 7,
        驾校 = 8,
        医生 = 9,
        残疾人购车 = 10,
        奖励 = 11,
        车改 = 12,
        教师 = 13,
        防护车 = 14,
        双燃料零售 = 15,
        医院 = 16,
        协议供货 = 17,
        大客户 = 18,
        拍卖 = 19,
        专项报告购车 = 20,
        经销商购车 = 21,
        领导干部购车 = 22
    }
    //派工单环节
    public enum DcsTaskAssignmentStage
    {
        其他 = 0,
        车身 = 1,
        底盘 = 2,
        电子电器 = 3,
        内外室 = 4,
        发动机 = 5,
        维护修理 = 6,
        接待 = 7,
        服务体验 = 8,
        质量检验 = 9,
        制单 = 10,
        预约 = 11,
        交验 = 12,
        服务后续 = 13,
        服务启动 = 14,
        PDI检查 = 15,
        产品介绍 = 16,
        后续服务及上牌 = 18,
        商谈成交 = 19,
        试乘试驾 = 20,
        新车交付 = 21,
        增值销售 = 22,
        备件订购 = 23,
        备件运输 = 24,
        到货更换 = 25,
        订单受理 = 26,
        精品件订购 = 27,
        特殊需求 = 28,
        需求受理 = 29,
        状态确认 = 30,
        资源保障 = 31,
        车型 = 32,
        外观 = 33,
        安全 = 34,
        性能 = 35,
        动力 = 36,
        定价 = 37,
        销售政策 = 38,
        促销活动 = 39,
        销售价格 = 40,
        销售渠道 = 41,
        销售流程 = 42,
        销售传播 = 43,
        硬件设施 = 44,
        服务流程 = 45,
        服务价格 = 46,
        服务活动 = 47,
        服务渠道 = 48,
        服务传播 = 49,
        客户关怀 = 50,
        备件价格 = 52,
        备件供应 = 54,
        供需保障 = 56,
        销售体验 = 57,
        关联服务 = 58
    }

    //变更类型
    public enum DcsRetainedCustomerChangeHistoryChangeType
    {
        新增 = 1,
        修改 = 2,
        删除 = 3,
        过户 = 4
    }
    //同步表状态
    public enum DcsCustomerCRMSyncStatus
    {
        未同步 = 0,
        已同步 = 1,
        过户 = 3
    }

    //大客户采购类型
    public enum DcsKeyAccountPurchaseType
    {
        政府 = 1,
        业务复审通过
    }

    //大客户政策申请状态
    public enum DcsKeyAccountPolicyApplyStatus
    {
        新建 = 1,
        提交 = 2,
        初审通过 = 3,
        初审不通过 = 4,
        复审通过 = 5,
        复审不通过 = 6,
        终审通过 = 7,
        终审不通过 = 8,
        业务复审通过 = 9,
        业务复审不通过 = 10
    }

    //来源工单
    public enum DcsTaskAssignmentSourceWorkSheet
    {
        热线 = 1,
        回访 = 2,
        邮件 = 3,
        传真 = 4,
        官网投诉 = 5,
        汽车投诉网 = 6,
        中国汽车质量网 = 7,
        汽车消费维权中心 = 8,
        网易汽车投诉网 = 9,
        中国汽车消费网 = 10,
        国家质检总局 = 11,
        中国质量万里行 = 12,
        总经办 = 13,
        在线客服 = 14,
        论坛 = 15,
        短信回复 = 16,
        公关部转发 = 17,
        RTX = 18,
        回电 = 19
    }

    //重大标记
    public enum DcsTaskAssignmentImportantMarke
    {
        保修拒赔 = 1,
        风云2顶腿 = 2,
        其他突发的重大问题标记 = 3,
        特殊投诉 = 4,
        预留做特殊重大问题标记 = 5,
        支持所有下拉框内容可自定义编辑_便于后期实时调整 = 6,
        重大事故 = 7,
        总部 = 8,
        艾瑞泽7抱怨 = 9,
        三包 = 10
    }

    //SSI调研
    public enum DcsPotentialCustomerVisitReportSurvey
    {
        成功 = 1,
        失败 = 2,
        未调研 = 3
    }

    //所属科室
    public enum DcsKADepStaffSettingDepartment
    {
        大客户专项开发科 = 1,
        大客户区域开发科 = 2,
        大客户支持科 = 3,
        大客户策略科 = 4
    }


    //属性内容
    public enum DcsKADepStaffSettingDetailAttributeContent
    {
        中直业务 = 1,
        省直业务 = 2,
        行业业务 = 3,
        安徽 = 4,
        河南 = 5,
        湖南 = 6,
        湖北 = 7,
        黑龙江 = 8,
        吉林 = 9,
        辽宁 = 10,
        内蒙古 = 11,
        山东 = 12,
        河北 = 13,
        山西 = 14,
        天津 = 15,
        北京 = 16,
        新疆 = 17,
        陕西 = 18,
        甘肃 = 19,
        宁夏 = 20,
        青海 = 21,
        广东 = 22,
        广西 = 23,
        海南 = 24,
        贵州 = 25,
        云南 = 26,
        四川 = 27,
        重庆 = 28,
        西藏 = 29,
        江苏 = 30,
        浙江 = 31,
        上海 = 32,
        江西 = 33,
        福建 = 34,
        直销 = 35,
        策略科 = 36,
        专项业务 = 37
    }

    //客户级别
    public enum DcsRetainedCustomerCustomerLevel
    {
        标准客户 = 101,
        临时客户 = 100,
        优质_超保进站 = 102,
        优质_领导干部 = 103,
        优质_购多台车 = 104,
        优质_意见领袖 = 105,
        优质_首批艾7 = 106,
        尊享卡_艾7 = 107,
        优质_瑞虎5 = 108,
        尊享卡_瑞虎5 = 109,
        优质_瑞虎5_ = 110
    }

    //经销商收车投诉与建议单状态
    public enum DcsReceivingComplainSuggestionStatus
    {
        新建 = 1,
        作废 = 99
    }

    //经销商收车投诉与建议单不满意原因
    public enum DcsReceivingComplainSuggestionNotSatisfiedReason
    {
        送车不及时 = 1,
        物流状态与VLS系统信息不符 = 2,
        承运商司机不配合解决问题_态度差 = 3,
        商品车有质损 = 4,
        随车资料不全 = 5,
        其他 = 6
    }
    //物流紧急业务处理申请单状态
    public enum DcsUrgentBusinessAppStatus
    {
        新建 = 1,
        生效 = 2,
        已回复 = 3,
        作废 = 99
    }

    //资源对调管理状态
    public enum DcsResourceExchangeStatus
    {
        新建 = 1,
        申请提报 = 2,
        申报确认 = 3,
        确认生效 = 4,
        审核通过 = 5,
        驳回 = 6,
        作废 = 99
    }

    //运费标准单价格属性
    public enum DcsTransportPricePriceAttribute
    {
        正式价 = 1,
        暂估价 = 2
    }

    //客户关怀单状态
    public enum DcsCustomerConcernInfoStatus
    {
        新建 = 1,
        生效 = 2,
        驳回 = 3,
        作废 = 99
    }

    //客户关怀接触点
    public enum DcsCustomerConcernInfoConcernPoint
    {
        元旦 = 1,
        春节 = 2,
        女人节 = 3,
        五一 = 4,
        端午 = 5,
        中秋 = 6,
        国庆 = 7,
        夏季特殊天气 = 8,
        冬季特殊天气 = 9,
        其他 = 10
    }

    //返利资料上传状态
    public enum DcsRebateMaterialUploadStatus
    {
        新建 = 1,
        提交 = 2,
        审核通过 = 3,
        审核不通过 = 4,
        作废 = 99
    }

    //不扫描合格证提报实销档案申请单状态
    public enum DcsNoneScanningCertificateAppStatus
    {
        新建 = 1,
        提交 = 2,
        审核通过 = 3,
        审核不通过 = 4,
        作废 = 99
    }

    //移动类型
    public enum DcsMobileType
    {
        冲销 = 1,
        非冲销 = 2
    }

    //移动成本中心控制
    public enum DcsMobileTypeSettlementObjectControl
    {
        必填 = 1,
        不允许编辑 = 2
    }

    //潜客来源
    public enum DmsPotentialCustomerConversionSource
    {
        来电 = 1,
        展厅 = 2,
        线索 = 3,
        手工导入 = 4
    }

    //合格证盘点范围
    public enum DcsCertificateInventoryRange
    {
        厂部仓库 = 1,
        经销商寄售库存 = 2
    }

    //终端合格证盘点范围
    public enum DcsTermiCertificateInventoryRange
    {
        大区 = 1,
        省份 = 2,
        经销商 = 3
    }

    //费用类型
    public enum DcsMarketEventPlanFeeType
    {
        区域广宣费 = 1,
        区域推广费 = 2,
        经销商自主 = 3,
        广宣费 = 4,
        推广费 = 5
    }

    /// <summary>
    /// 大客户项目跟踪状态
    /// </summary>
    public enum DcsKeyAccountProjectFollowStatus
    {
        市场调研 = 1,
        商务公关 = 2,
        商务洽谈 = 3,
        形成意向 = 4,
        签订合同 = 5,
        车辆交付 = 6,
    }

    /// <summary>
    /// 项目返利预判
    /// </summary>
    public enum DcsKeyAccountPolicyApplyRebateAnticipation
    {
        主观属实 = 1,
        客观属实 = 2,
        常规项目 = 3
    }

    //有望确度
    public enum DcsPotentialCustomerLevelOfIntent
    {
        FO = 1,
        A = 2,
        B = 3,
        C = 4,
        N = 5,
        S = 6,
        O = 7,
        F = 0
    }

    //购车预算
    public enum DcsPurchaseBudget
    {
        _30000_50000 = 1,
        _50000_100000 = 2,
        _100000_150000 = 3,
        _150000以上 = 4,
    }

    /// <summary>
    /// 线索战败原因
    /// </summary>
    public enum DcsSaleleadLeadFailReason
    {
        暂无购车意向 = 1,
        号码错误或联系不上 = 2,
        潜在客户重复 = 3,
        非本区域用户 = 4,
        已购车 = 5,
        其他 = 6
    }

    /// <summary>
    /// 投保公司
    /// </summary>
    public enum DcsRetailContractCarInsuranceName
    {
        中国人保 = 1,
        中国平安 = 2,
        太平洋保险 = 3,
        国寿财险 = 4,
        中华联合保险 = 5,
        大地保险 = 6,
        阳光产险 = 7,
        永诚产险 = 8,
        其他 = 9,
    }

    /// <summary>
    /// 投保险种
    /// </summary>
    public enum DcsRetailContractInsuranceType
    {
        车损险 = 1,
        商业三责 = 2,
        车上人员责任险 = 3,
        盗抢险 = 4,
        玻璃单独破碎 = 5,
        不计免赔 = 6,
        指定专修厂 = 7,
        涉水险 = 8,
        自燃险 = 9
    }

    /// <summary>
    /// 电商平台
    /// </summary>
    public enum DcsECAccountPlatform
    {
        汽车之家 = 1
    }

    /// <summary>
    /// 预计提车时间
    /// </summary>
    public enum DcsSalesLeadExpectedDeliverDate
    {
        _15天以内 = 1,
        _30天以内 = 2,
        _30天以外 = 3
    }

    /// <summary>
    /// 试乘试驾状态
    /// </summary>
    public enum DcsTestDriveRecordStatus
    {
        作废 = 99,
        新增 = 1,
        有效 = 2,
        试驾中 = 3,
        归还 = 4
    }


    //试乘试驾类型
    public enum DcsTestDriveRecordTestDriverType
    {
        试乘试驾 = 0,
        试乘 = 1
    }

    //整车冻结单清单状态
    public enum DcsVehicleDamageDetailStatus
    {
        已冻结 = 1,
        已解冻 = 2
    }
    //试乘试驾车申请单申请类型
    public enum DcsTestDriveApplyApplyType
    {
        新增 = 1,
        变更 = 2
    }
    //原试乘试驾车处理方式
    public enum DcsTestDriveApplyOriginalCarType
    {
        保留 = 1,
        退役 = 2
    }
    //试乘试驾车申请单状态
    public enum DcsTestDriveApplyStatus
    {
        新增 = 1,
        已提交待审核 = 2,
        审核通过 = 3,
        审核不通过 = 4,
        作废 = 99
    }

    /// <summary>
    /// 经销商经营信息状态
    /// </summary>
    public enum DcsDealerBusinessInfoStatus
    {
        新增 = 1,
        提交 = 2,
        驳回 = 3
    }
    /// <summary>
    /// 季度
    /// </summary>
    public enum DcsDealerBusinessInfoQuarter
    {
        _1季度 = 1,
        _1_2季度 = 2,
        _1_3季度 = 3,
        _1_4季度 = 4
    }
    /// <summary>
    /// 月度
    /// </summary>
    public enum DcsDealerBusinessInfoMonth
    {
        _1月 = 1,
        _1_2月 = 2,
        _1_3月 = 3,
        _1_4月 = 4,
        _1_5月 = 5,
        _1_6月 = 6,
        _1_7月 = 7,
        _1_8月 = 8,
        _1_9月 = 9,
        _1_10月 = 10,
        _1_11月 = 11,
        _1_12月 = 12,
    }

    /// <summary>
    /// 不扫描原因
    /// </summary>
    public enum DcsNoneScanningCertificateAppReason
    {
        扫描无反应且显示倒计时 = 1,
        扫描显示RFID非法 = 2,
        读卡器未到店或读卡器损坏 = 3,
        合格证被客户拿走上牌 = 4,
        金融贷款车或其他业务原因致合格证未到 = 5,
        断网或断电或系统故障无法传档案 = 6,
        其他原因 = 7
    }

    /// <summary>
    /// 首触平台
    /// </summary>
    public enum DcsSalesLeadFirstTouchPlatform
    {
        厂端下发 = 1,
        易车网 = 2,
        汽车之家 = 3,
        其他 = 4,
        潜客 = 5,
        官网 = 6,
        爱卡汽车网 = 7,
        太平洋汽车网 = 8
    }
    public enum DcsPotentialCustomerConversionSource
    {
        来店 = 1,
        展厅 = 2,
        线索 = 3,
        手工导入 = 4
    }

    /// <summary>
    /// 经销商库存调剂单状态
    /// </summary>
    public enum DcsVehicleStockCoordinationStatus
    {
        新增 = 1,
        大区审批中 = 2,
        大区审批失败 = 3,
        公司审批中 = 4,
        公司审批失败 = 5,
        信息发布中 = 6,
        意向达成 = 7,
        作废 = 99
    }

    /// <summary>
    /// 经销商库存调剂单经销商买卖
    /// </summary>
    public enum DcsVehicleStockCoordinationType
    {
        已交易 = 1,
        未交易 = 2
    }

    /// <summary>
    /// 经销商库存调剂单状态发布范围
    /// </summary>
    public enum DcsVehicleStockCoordinationRange
    {
        同城 = 1,
        同区 = 2,
        全国 = 3
    }
    /// <summary>
    /// 二手车置换状态
    /// </summary>
    public enum DcsSecondHandCarExchangeStatus
    {
        新建 = 1,
        已提交 = 2,
        审核通过 = 3,
        审核不通过 = 4,
        作废 = 99
    }
    /// <summary>
    /// 二手车置换类型
    /// </summary>
    public enum DcsSecondHandCarExchangeType
    {
        过户 = 1,
        转籍 = 2,
        报废 = 3
    }
    /// <summary>
    /// 经销商人员变更申请单流失原因
    /// </summary>
    public enum DcsDealerEmployeeChangeAppLossReasonItem
    {
        集团内部调动至其他汽车品牌4S店 = 1,
        个人选择其他品牌经销商 = 2,
        自主创业 = 3,
        薪酬原因 = 4,
        发展空间 = 5,
        其他原因 = 6
    }
    /// <summary>
    /// 整车发运单结算状态
    /// </summary>
    public enum DcsVehicleShippingOrderSettleStatus
    {
        未结算 = 0,
        全部结算 = 1,
        部分结算 = 2
    }

    /// <summary>
    /// 市场活动费用结算单状态
    /// </summary>
    public enum DcsMarketEventSettleStatus
    {
        新建 = 1,
        提交 = 2,
        大区审核通过 = 3,
        大区审核不通过 = 4,
        大区复核通过 = 5,
        大区复核不通过 = 6,
        大区驳回 = 7,
        企划审核通过 = 8,
        企划审核不通过 = 9,
        企划复核通过 = 10,
        企划复核不通过 = 11,
        财务审核通过 = 12,
        财务审核不通过 = 13,
        财务复核通过 = 14,
        财务复核不通过 = 15,
        财务批准通过 = 16,
        财务批准不通过 = 17,
        作废 = 99
    }

    /// <summary>
    /// 市场活动费用结算单下步操作
    /// </summary>
    public enum DcsMarketEventSettleNextStep
    {
        修改or提交or作废 = 1,
        修改or作废 = 2,
        修改 = 3,
        大区审核 = 4,
        大区复核 = 5,
        企划审核 = 6,
        企划复核 = 7,
        财务审核 = 8,
        财务复核 = 9,
        财务批准 = 10,
        大区驳回 = 11,
        流程结束 = 12
    }

    /// <summary>
    /// 市场活动费用结算单附件类型
    /// </summary>
    public enum DcsMarketEventSettleFileType
    {
        图片 = 1,
        文件 = 2,
        音频视频 = 3,
        其他 = 4
    }
    /// <summary>
    /// 经销商资产负债状态
    /// </summary>
    public enum DcsDealerAssetsLiabilitiyStatus
    {
        新建 = 1,
        提交 = 2,
        驳回 = 3

    }
    /// <summary>
    /// 经销商现金流量状态
    /// </summary>
    public enum DcsDealerCashFlowStatus
    {
        新建 = 1,
        提交 = 2,
        驳回 = 3

    }
    /// <summary>
    /// 经销商利润信息状态
    /// </summary>
    public enum DcsDealerProfitInformationStatus
    {
        新建 = 1,
        提交 = 2,
        驳回 = 3

    }
}
