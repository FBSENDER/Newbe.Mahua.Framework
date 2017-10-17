using System.Runtime.InteropServices;
using Newbe.Mahua.CQP.NativeApi;

namespace Newbe.Mahua.CQP.Native
{


    public class CoolQApi : ICoolQApi
    {
        /// <summary>
        /// ���ͺ�����Ϣ
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="QQID">Ŀ��QQ</param>
        /// <param name="msg">��Ϣ����</param>
        /// <returns></returns>
        int ICoolQApi.CQ_sendPrivateMsg(int AuthCode, long QQID, string msg)
            => NativeMethods.CQ_sendPrivateMsg(AuthCode, QQID, msg);

        /// <summary>
        /// ����Ⱥ��Ϣ
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="Ⱥ��">Ŀ��Ⱥ</param>
        /// <param name="msg">��Ϣ����</param>
        /// <returns></returns>
        int ICoolQApi.CQ_sendGroupMsg(int AuthCode, long Ⱥ��, string msg)
            => NativeMethods.CQ_sendGroupMsg(AuthCode, Ⱥ��, msg);

        /// <summary>
        /// ������������Ϣ
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="�������">Ŀ��������</param>
        /// <param name="msg">��Ϣ����</param>
        /// <returns></returns>
        int ICoolQApi.CQ_sendDiscussMsg(int AuthCode, long �������, string msg)
            => NativeMethods.CQ_sendDiscussMsg(AuthCode, �������, msg);

        /// <summary>
        /// ������
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="QQID">Ŀ��QQ</param>
        /// <returns></returns>
        int ICoolQApi.CQ_sendLike(int AuthCode, long QQID)
            => NativeMethods.CQ_sendLike(AuthCode, QQID);

        /// <summary>
        /// ������
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="QQID">Ŀ��QQ</param>
        /// <param name="times">�޵Ĵ��������10��</param>
        /// <returns></returns>
        int ICoolQApi.CQ_sendLikeV2(int AuthCode, long QQID, int times)
            => NativeMethods.CQ_sendLikeV2(AuthCode, QQID, times);

        /// <summary>
        /// ȡCookies(����
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string ICoolQApi.CQ_getCookies(int AuthCode)
            => NativeMethods.CQ_getCookies(AuthCode);

        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="file">�յ���Ϣ�е������ļ���(file)</param>
        /// <param name="outformat">Ӧ������ĸ�ʽ</param>
        /// <returns></returns>
        string ICoolQApi.CQ_getRecord(int AuthCode, string file, string outformat)
            => NativeMethods.CQ_getRecord(AuthCode, file, outformat);

        /// <summary>
        /// ȡCsrfToken(����
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        int ICoolQApi.CQ_getCsrfToken(int AuthCode)
            => NativeMethods.CQ_getCsrfToken(AuthCode);

        /// <summary>
        /// ȡӦ��Ŀ¼
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string ICoolQApi.CQ_getAppDirectory(int AuthCode)
            => NativeMethods.CQ_getAppDirectory(AuthCode);

        /// <summary>
        /// ȡ��¼QQ
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        long ICoolQApi.CQ_getLoginQQ(int AuthCode)
            => NativeMethods.CQ_getLoginQQ(AuthCode);

        /// <summary>
        /// ȡ��¼�ǳ�
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <returns></returns>
        string ICoolQApi.CQ_getLoginNick(int AuthCode)
            => NativeMethods.CQ_getLoginNick(AuthCode);

        /// <summary>
        /// ��ȺԱ�Ƴ�
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="Ⱥ��">Ŀ��Ⱥ</param>
        /// <param name="QQID">Ŀ��QQ</param>
        /// <param name="�ܾ��ټ�Ⱥ">���Ϊ�棬�򡰲��ٽ��մ��˼�Ⱥ���롱��������</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupKick(int AuthCode, long Ⱥ��, long QQID, bool �ܾ��ټ�Ⱥ)
            => NativeMethods.CQ_setGroupKick(AuthCode, Ⱥ��, QQID, �ܾ��ټ�Ⱥ);

        /// <summary>
        /// ��ȺԱ����
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="Ⱥ��">Ŀ��Ⱥ</param>
        /// <param name="QQID">Ŀ��QQ</param>
        /// <param name="����ʱ��">���Ե�ʱ�䣬��λΪ�롣���Ҫ�����������д0</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupBan(int AuthCode, long Ⱥ��, long QQID, long ����ʱ��)
            => NativeMethods.CQ_setGroupBan(AuthCode, Ⱥ��, QQID, ����ʱ��);

        /// <summary>
        /// ��Ⱥ����Ա
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="Ⱥ��">Ŀ��Ⱥ</param>
        /// <param name="QQID">�����õ�QQ</param>
        /// <param name="��Ϊ����Ա">��/���ù���Ա ��/ȡ������Ա</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupAdmin(int AuthCode, long Ⱥ��, long QQID, bool ��Ϊ����Ա)
            => NativeMethods.CQ_setGroupAdmin(AuthCode, Ⱥ��, QQID, ��Ϊ����Ա);

        /// <summary>
        /// ��Ⱥ��Աר��ͷ��
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="Ⱥ��">Ŀ��Ⱥ</param>
        /// <param name="QQID">Ŀ��QQ</param>
        /// <param name="ͷ��">���Ҫɾ�����������</param>
        /// <param name="����ʱ��">ר��ͷ����Ч�ڣ���λΪ�롣���������Ч��������д-1</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupSpecialTitle(int AuthCode, long Ⱥ��, long QQID, string ͷ��, long ����ʱ��)
            => NativeMethods.CQ_setGroupSpecialTitle(AuthCode, Ⱥ��, QQID, ͷ��, ����ʱ��);

        /// <summary>
        /// ��ȫȺ����
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="Ⱥ��">Ŀ��Ⱥ</param>
        /// <param name="��������">��/���� ��/�ر�</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupWholeBan(int AuthCode, long Ⱥ��, bool ��������)
            => NativeMethods.CQ_setGroupWholeBan(AuthCode, Ⱥ��, ��������);

        /// <summary>
        /// ������ȺԱ����
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="Ⱥ��">Ŀ��Ⱥ</param>
        /// <param name="����">Ⱥ��Ϣ�¼��յ��ġ�����������</param>
        /// <param name="����ʱ��">���Ե�ʱ�䣬��λΪ�롣��֧�ֽ��</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupAnonymousBan(int AuthCode, long Ⱥ��, string ����, long ����ʱ��)
            => NativeMethods.CQ_setGroupAnonymousBan(AuthCode, Ⱥ��, ����, ����ʱ��);

        /// <summary>
        /// ��Ⱥ��������
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="Ⱥ��"></param>
        /// <param name="��������"></param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupAnonymous(int AuthCode, long Ⱥ��, bool ��������)
            => NativeMethods.CQ_setGroupAnonymous(AuthCode, Ⱥ��, ��������);

        /// <summary>
        /// ��Ⱥ��Ա��Ƭ
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="Ⱥ��">Ŀ��Ⱥ</param>
        /// <param name="QQID">�����õ�QQ</param>
        /// <param name="����Ƭ_�ǳ�"></param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupCard(int AuthCode, long Ⱥ��, long QQID, string ����Ƭ_�ǳ�)
            => NativeMethods.CQ_setGroupCard(AuthCode, Ⱥ��, QQID, ����Ƭ_�ǳ�);

        /// <summary>
        /// ��Ⱥ�˳�
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="Ⱥ��">Ŀ��Ⱥ</param>
        /// <param name="�Ƿ��ɢ">��/��ɢ��Ⱥ(Ⱥ��) ��/�˳���Ⱥ(����Ⱥ��Ա)</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupLeave(int AuthCode, long Ⱥ��, bool �Ƿ��ɢ)
            => NativeMethods.CQ_setGroupLeave(AuthCode, Ⱥ��, �Ƿ��ɢ);

        /// <summary>
        /// ���������˳�
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="�������">Ŀ��������</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setDiscussLeave(int AuthCode, long �������)
            => NativeMethods.CQ_setDiscussLeave(AuthCode, �������);

        /// <summary>
        /// �ú����������
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="��������ʶ">�����¼��յ��ġ�������ʶ������</param>
        /// <param name="��������">#����_ͨ�� �� #����_�ܾ�</param>
        /// <param name="��ע">��Ӻ�ĺ��ѱ�ע</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setFriendAddRequest(int AuthCode, string ��������ʶ, int ��������, string ��ע)
            => NativeMethods.CQ_setFriendAddRequest(AuthCode, ��������ʶ, ��������, ��ע);

        /// <summary>
        /// ��Ⱥ�������
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="��������ʶ">�����¼��յ��ġ�������ʶ������</param>
        /// <param name="��������">���������¼������������� #����_Ⱥ��� �� #����_Ⱥ����</param>
        /// <param name="��������">#����_ͨ�� �� #����_�ܾ�</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupAddRequest(int AuthCode, string ��������ʶ, int ��������, int ��������)
            => NativeMethods.CQ_setGroupAddRequest(AuthCode, ��������ʶ, ��������, ��������);

        /// <summary>
        /// ��Ⱥ�������
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="��������ʶ">�����¼��յ��ġ�������ʶ������</param>
        /// <param name="��������">���������¼������������� #����_Ⱥ��� �� #����_Ⱥ����</param>
        /// <param name="��������">#����_ͨ�� �� #����_�ܾ�</param>
        /// <param name="����">�������ɣ��� #����_Ⱥ��� �� #����_�ܾ� ʱ����</param>
        /// <returns></returns>
        int ICoolQApi.CQ_setGroupAddRequestV2(int AuthCode, string ��������ʶ, int ��������, int ��������, string ����)
            => NativeMethods.CQ_setGroupAddRequestV2(AuthCode, ��������ʶ, ��������, ��������, ����);

        /// <summary>
        /// ����������־
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="���ȼ�">#Log_ ��ͷ����</param>
        /// <param name="����"></param>
        /// <param name="����"></param>
        /// <returns></returns>
        int ICoolQApi.CQ_addLog(int AuthCode, int ���ȼ�, string ����, string ����)
            => NativeMethods.CQ_addLog(AuthCode, ���ȼ�, ����, ����);

        /// <summary>
        /// ������������ʾ
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="������Ϣ"></param>
        /// <returns></returns>
        int ICoolQApi.CQ_setFatal(int AuthCode, string ������Ϣ)
            => NativeMethods.CQ_setFatal(AuthCode, ������Ϣ);

        /// <summary>
        /// ȡȺ��Ա��Ϣ(�ɰ�
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="Ⱥ��">Ŀ��QQ����Ⱥ</param>
        /// <param name="QQID">Ŀ��QQ</param>
        /// <returns></returns>
        string ICoolQApi.CQ_getGroupMemberInfo(int AuthCode, long Ⱥ��, long QQID)
            => NativeMethods.CQ_getGroupMemberInfo(AuthCode, Ⱥ��, QQID);

        /// <summary>
        /// ȡȺ��Ա��Ϣ(֧�ֻ���)
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="Ⱥ��">Ŀ��QQ����Ⱥ</param>
        /// <param name="QQID">Ŀ��QQ</param>
        /// <param name="��ʹ�û���"></param>
        /// <returns></returns>
        string ICoolQApi.CQ_getGroupMemberInfoV2(int AuthCode, long Ⱥ��, long QQID, bool ��ʹ�û���)
            => NativeMethods.CQ_getGroupMemberInfoV2(AuthCode, Ⱥ��, QQID, ��ʹ�û���);

        /// <summary>
        /// ȡȺ��Ա�б�
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="Ⱥ��">Ŀ��QQ����Ⱥ</param>
        /// <returns></returns>
        string ICoolQApi.CQ_getGroupMemberList(int AuthCode, long Ⱥ��)
            => NativeMethods.CQ_getGroupMemberList(AuthCode, Ⱥ��);

        /// <summary>
        /// ȡİ������Ϣ(֧�ֻ���)
        /// </summary>
        /// <param name="AuthCode"></param>
        /// <param name="QQID">Ŀ��QQ</param>
        /// <param name="��ʹ�û���"></param>
        /// <returns></returns>
        string ICoolQApi.CQ_getStrangerInfo(int AuthCode, long QQID, bool ��ʹ�û���)
            => NativeMethods.CQ_getStrangerInfo(AuthCode, QQID, ��ʹ�û���);

        /// <summary>
        /// ȡȺ�б�
        /// </summary>
        /// <returns></returns>
        string ICoolQApi.CQ_getGroupList(int AuthCode) => NativeMethods.CQ_getGroupList(AuthCode);

        private static class NativeMethods
        {
            /// <summary>
            /// ���ͺ�����Ϣ
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="QQID">Ŀ��QQ</param>
            /// <param name="msg">��Ϣ����</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_sendPrivateMsg(int AuthCode, long QQID, string msg);

            /// <summary>
            /// ����Ⱥ��Ϣ
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="Ⱥ��">Ŀ��Ⱥ</param>
            /// <param name="msg">��Ϣ����</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_sendGroupMsg(int AuthCode, long Ⱥ��, string msg);

            /// <summary>
            /// ������������Ϣ
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="�������">Ŀ��������</param>
            /// <param name="msg">��Ϣ����</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_sendDiscussMsg(int AuthCode, long �������, string msg);

            /// <summary>
            /// ������
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="QQID">Ŀ��QQ</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_sendLike(int AuthCode, long QQID);

            /// <summary>
            /// ������
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="QQID">Ŀ��QQ</param>
            /// <param name="times">�޵Ĵ��������10��</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_sendLikeV2(int AuthCode, long QQID, int times);

            /// <summary>
            /// ȡCookies(����
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern string CQ_getCookies(int AuthCode);

            /// <summary>
            /// ��������
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="file">�յ���Ϣ�е������ļ���(file)</param>
            /// <param name="outformat">Ӧ������ĸ�ʽ</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern string CQ_getRecord(int AuthCode, string file, string outformat);

            /// <summary>
            /// ȡCsrfToken(����
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_getCsrfToken(int AuthCode);

            /// <summary>
            /// ȡӦ��Ŀ¼
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern string CQ_getAppDirectory(int AuthCode);

            /// <summary>
            /// ȡ��¼QQ
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern long CQ_getLoginQQ(int AuthCode);

            /// <summary>
            /// ȡ��¼�ǳ�
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern string CQ_getLoginNick(int AuthCode);

            /// <summary>
            /// ��ȺԱ�Ƴ�
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="Ⱥ��">Ŀ��Ⱥ</param>
            /// <param name="QQID">Ŀ��QQ</param>
            /// <param name="�ܾ��ټ�Ⱥ">���Ϊ�棬�򡰲��ٽ��մ��˼�Ⱥ���롱��������</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupKick(int AuthCode, long Ⱥ��, long QQID, bool �ܾ��ټ�Ⱥ);

            /// <summary>
            /// ��ȺԱ����
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="Ⱥ��">Ŀ��Ⱥ</param>
            /// <param name="QQID">Ŀ��QQ</param>
            /// <param name="����ʱ��">���Ե�ʱ�䣬��λΪ�롣���Ҫ�����������д0</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupBan(int AuthCode, long Ⱥ��, long QQID, long ����ʱ��);

            /// <summary>
            /// ��Ⱥ����Ա
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="Ⱥ��">Ŀ��Ⱥ</param>
            /// <param name="QQID">�����õ�QQ</param>
            /// <param name="��Ϊ����Ա">��/���ù���Ա ��/ȡ������Ա</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupAdmin(int AuthCode, long Ⱥ��, long QQID, bool ��Ϊ����Ա);

            /// <summary>
            /// ��Ⱥ��Աר��ͷ��
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="Ⱥ��">Ŀ��Ⱥ</param>
            /// <param name="QQID">Ŀ��QQ</param>
            /// <param name="ͷ��">���Ҫɾ�����������</param>
            /// <param name="����ʱ��">ר��ͷ����Ч�ڣ���λΪ�롣���������Ч��������д-1</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupSpecialTitle(int AuthCode, long Ⱥ��, long QQID, string ͷ��, long ����ʱ��);

            /// <summary>
            /// ��ȫȺ����
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="Ⱥ��">Ŀ��Ⱥ</param>
            /// <param name="��������">��/���� ��/�ر�</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupWholeBan(int AuthCode, long Ⱥ��, bool ��������);

            /// <summary>
            /// ������ȺԱ����
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="Ⱥ��">Ŀ��Ⱥ</param>
            /// <param name="����">Ⱥ��Ϣ�¼��յ��ġ�����������</param>
            /// <param name="����ʱ��">���Ե�ʱ�䣬��λΪ�롣��֧�ֽ��</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupAnonymousBan(int AuthCode, long Ⱥ��, string ����, long ����ʱ��);

            /// <summary>
            /// ��Ⱥ��������
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="Ⱥ��"></param>
            /// <param name="��������"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupAnonymous(int AuthCode, long Ⱥ��, bool ��������);

            /// <summary>
            /// ��Ⱥ��Ա��Ƭ
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="Ⱥ��">Ŀ��Ⱥ</param>
            /// <param name="QQID">�����õ�QQ</param>
            /// <param name="����Ƭ_�ǳ�"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupCard(int AuthCode, long Ⱥ��, long QQID, string ����Ƭ_�ǳ�);

            /// <summary>
            /// ��Ⱥ�˳�
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="Ⱥ��">Ŀ��Ⱥ</param>
            /// <param name="�Ƿ��ɢ">��/��ɢ��Ⱥ(Ⱥ��) ��/�˳���Ⱥ(����Ⱥ��Ա)</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupLeave(int AuthCode, long Ⱥ��, bool �Ƿ��ɢ);

            /// <summary>
            /// ���������˳�
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="�������">Ŀ��������</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setDiscussLeave(int AuthCode, long �������);

            /// <summary>
            /// �ú����������
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="��������ʶ">�����¼��յ��ġ�������ʶ������</param>
            /// <param name="��������">#����_ͨ�� �� #����_�ܾ�</param>
            /// <param name="��ע">��Ӻ�ĺ��ѱ�ע</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setFriendAddRequest(int AuthCode, string ��������ʶ, int ��������, string ��ע);

            /// <summary>
            /// ��Ⱥ�������
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="��������ʶ">�����¼��յ��ġ�������ʶ������</param>
            /// <param name="��������">���������¼������������� #����_Ⱥ��� �� #����_Ⱥ����</param>
            /// <param name="��������">#����_ͨ�� �� #����_�ܾ�</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupAddRequest(int AuthCode, string ��������ʶ, int ��������, int ��������);

            /// <summary>
            /// ��Ⱥ�������
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="��������ʶ">�����¼��յ��ġ�������ʶ������</param>
            /// <param name="��������">���������¼������������� #����_Ⱥ��� �� #����_Ⱥ����</param>
            /// <param name="��������">#����_ͨ�� �� #����_�ܾ�</param>
            /// <param name="����">�������ɣ��� #����_Ⱥ��� �� #����_�ܾ� ʱ����</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setGroupAddRequestV2(int AuthCode, string ��������ʶ, int ��������, int ��������,
                string ����);

            /// <summary>
            /// ����������־
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="���ȼ�">#Log_ ��ͷ����</param>
            /// <param name="����"></param>
            /// <param name="����"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_addLog(int AuthCode, int ���ȼ�, string ����, string ����);

            /// <summary>
            /// ������������ʾ
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="������Ϣ"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern int CQ_setFatal(int AuthCode, string ������Ϣ);

            /// <summary>
            /// ȡȺ��Ա��Ϣ(�ɰ�
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="Ⱥ��">Ŀ��QQ����Ⱥ</param>
            /// <param name="QQID">Ŀ��QQ</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern string CQ_getGroupMemberInfo(int AuthCode, long Ⱥ��, long QQID);

            /// <summary>
            /// ȡȺ��Ա��Ϣ(֧�ֻ���)
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="Ⱥ��">Ŀ��QQ����Ⱥ</param>
            /// <param name="QQID">Ŀ��QQ</param>
            /// <param name="��ʹ�û���"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern string CQ_getGroupMemberInfoV2(int AuthCode, long Ⱥ��, long QQID, bool ��ʹ�û���);

            /// <summary>
            /// ȡȺ��Ա�б�
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="Ⱥ��">Ŀ��QQ����Ⱥ</param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern string CQ_getGroupMemberList(int AuthCode, long Ⱥ��);

            /// <summary>
            /// ȡİ������Ϣ(֧�ֻ���)
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <param name="QQID">Ŀ��QQ</param>
            /// <param name="��ʹ�û���"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern string CQ_getStrangerInfo(int AuthCode, long QQID, bool ��ʹ�û���);

            /// <summary>
            /// ȡȺ�б�
            /// </summary>
            /// <param name="AuthCode"></param>
            /// <returns></returns>
            [DllImport("CQP.dll")]
            public static extern string CQ_getGroupList(int AuthCode);
        }
    }
}
