using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Xml.Serialization;

namespace XHX.Common
{
    [Serializable]
    public abstract class BufferColumnDto
    {
        #region Method(s)

        #region GetDataList

        public IList GetDataList()
        {
            ArrayList list = new ArrayList();

            if (_data001 != null) list.Add(_data001);
            if (_data002 != null) list.Add(_data002);
            if (_data003 != null) list.Add(_data003);
            if (_data004 != null) list.Add(_data004);
            if (_data005 != null) list.Add(_data005);
            if (_data006 != null) list.Add(_data006);
            if (_data007 != null) list.Add(_data007);
            if (_data008 != null) list.Add(_data008);
            if (_data009 != null) list.Add(_data009);
            if (_data010 != null) list.Add(_data010);
            if (_data011 != null) list.Add(_data011);
            if (_data012 != null) list.Add(_data012);
            if (_data013 != null) list.Add(_data013);
            if (_data014 != null) list.Add(_data014);
            if (_data015 != null) list.Add(_data015);
            if (_data016 != null) list.Add(_data016);
            if (_data017 != null) list.Add(_data017);
            if (_data018 != null) list.Add(_data018);
            if (_data019 != null) list.Add(_data019);
            if (_data020 != null) list.Add(_data020);
            if (_data021 != null) list.Add(_data021);
            if (_data022 != null) list.Add(_data022);
            if (_data023 != null) list.Add(_data023);
            if (_data024 != null) list.Add(_data024);
            if (_data025 != null) list.Add(_data025);
            if (_data026 != null) list.Add(_data026);
            if (_data027 != null) list.Add(_data027);
            if (_data028 != null) list.Add(_data028);
            if (_data029 != null) list.Add(_data029);
            if (_data030 != null) list.Add(_data030);
            if (_data031 != null) list.Add(_data031);
            if (_data032 != null) list.Add(_data032);
            if (_data033 != null) list.Add(_data033);
            if (_data034 != null) list.Add(_data034);
            if (_data035 != null) list.Add(_data035);
            if (_data036 != null) list.Add(_data036);
            if (_data037 != null) list.Add(_data037);
            if (_data038 != null) list.Add(_data038);
            if (_data039 != null) list.Add(_data039);
            if (_data040 != null) list.Add(_data040);
            if (_data041 != null) list.Add(_data041);
            if (_data042 != null) list.Add(_data042);
            if (_data043 != null) list.Add(_data043);
            if (_data044 != null) list.Add(_data044);
            if (_data045 != null) list.Add(_data045);
            if (_data046 != null) list.Add(_data046);
            if (_data047 != null) list.Add(_data047);
            if (_data048 != null) list.Add(_data048);
            if (_data049 != null) list.Add(_data049);
            if (_data050 != null) list.Add(_data050);
            if (_data051 != null) list.Add(_data051);
            if (_data052 != null) list.Add(_data052);
            if (_data053 != null) list.Add(_data053);
            if (_data054 != null) list.Add(_data054);
            if (_data055 != null) list.Add(_data055);
            if (_data056 != null) list.Add(_data056);
            if (_data057 != null) list.Add(_data057);
            if (_data058 != null) list.Add(_data058);
            if (_data059 != null) list.Add(_data059);
            if (_data060 != null) list.Add(_data060);
            if (_data061 != null) list.Add(_data061);
            if (_data062 != null) list.Add(_data062);
            if (_data063 != null) list.Add(_data063);
            if (_data064 != null) list.Add(_data064);
            if (_data065 != null) list.Add(_data065);
            if (_data066 != null) list.Add(_data066);
            if (_data067 != null) list.Add(_data067);
            if (_data068 != null) list.Add(_data068);
            if (_data069 != null) list.Add(_data069);
            if (_data070 != null) list.Add(_data070);
            if (_data071 != null) list.Add(_data071);
            if (_data072 != null) list.Add(_data072);
            if (_data073 != null) list.Add(_data073);
            if (_data074 != null) list.Add(_data074);
            if (_data075 != null) list.Add(_data075);
            if (_data076 != null) list.Add(_data076);
            if (_data077 != null) list.Add(_data077);
            if (_data078 != null) list.Add(_data078);
            if (_data079 != null) list.Add(_data079);
            if (_data080 != null) list.Add(_data080);
            if (_data081 != null) list.Add(_data081);
            if (_data082 != null) list.Add(_data082);
            if (_data083 != null) list.Add(_data083);
            if (_data084 != null) list.Add(_data084);
            if (_data085 != null) list.Add(_data085);
            if (_data086 != null) list.Add(_data086);
            if (_data087 != null) list.Add(_data087);
            if (_data088 != null) list.Add(_data088);
            if (_data089 != null) list.Add(_data089);
            if (_data090 != null) list.Add(_data090);
            if (_data091 != null) list.Add(_data091);
            if (_data092 != null) list.Add(_data092);
            if (_data093 != null) list.Add(_data093);
            if (_data094 != null) list.Add(_data094);
            if (_data095 != null) list.Add(_data095);
            if (_data096 != null) list.Add(_data096);
            if (_data097 != null) list.Add(_data097);
            if (_data098 != null) list.Add(_data098);
            if (_data099 != null) list.Add(_data099);
            if (_data100 != null) list.Add(_data100);
            if (_data101 != null) list.Add(_data101);
            if (_data102 != null) list.Add(_data102);
            if (_data103 != null) list.Add(_data103);
            if (_data104 != null) list.Add(_data104);
            if (_data105 != null) list.Add(_data105);
            if (_data106 != null) list.Add(_data106);
            if (_data107 != null) list.Add(_data107);
            if (_data108 != null) list.Add(_data108);
            if (_data109 != null) list.Add(_data109);
            if (_data110 != null) list.Add(_data110);
            if (_data111 != null) list.Add(_data111);
            if (_data112 != null) list.Add(_data112);
            if (_data113 != null) list.Add(_data113);
            if (_data114 != null) list.Add(_data114);
            if (_data115 != null) list.Add(_data115);
            if (_data116 != null) list.Add(_data116);
            if (_data117 != null) list.Add(_data117);
            if (_data118 != null) list.Add(_data118);
            if (_data119 != null) list.Add(_data119);
            if (_data120 != null) list.Add(_data120);
            if (_data121 != null) list.Add(_data121);
            if (_data122 != null) list.Add(_data122);
            if (_data123 != null) list.Add(_data123);
            if (_data124 != null) list.Add(_data124);
            if (_data125 != null) list.Add(_data125);
            if (_data126 != null) list.Add(_data126);
            if (_data127 != null) list.Add(_data127);
            if (_data128 != null) list.Add(_data128);
            if (_data129 != null) list.Add(_data129);
            if (_data130 != null) list.Add(_data130);
            if (_data131 != null) list.Add(_data131);
            if (_data132 != null) list.Add(_data132);
            if (_data133 != null) list.Add(_data133);
            if (_data134 != null) list.Add(_data134);
            if (_data135 != null) list.Add(_data135);
            if (_data136 != null) list.Add(_data136);
            if (_data137 != null) list.Add(_data137);
            if (_data138 != null) list.Add(_data138);
            if (_data139 != null) list.Add(_data139);
            if (_data140 != null) list.Add(_data140);
            if (_data141 != null) list.Add(_data141);
            if (_data142 != null) list.Add(_data142);
            if (_data143 != null) list.Add(_data143);
            if (_data144 != null) list.Add(_data144);
            if (_data145 != null) list.Add(_data145);
            if (_data146 != null) list.Add(_data146);
            if (_data147 != null) list.Add(_data147);
            if (_data148 != null) list.Add(_data148);
            if (_data149 != null) list.Add(_data149);
            if (_data150 != null) list.Add(_data150);
            if (_data151 != null) list.Add(_data151);
            if (_data152 != null) list.Add(_data152);
            if (_data153 != null) list.Add(_data153);
            if (_data154 != null) list.Add(_data154);
            if (_data155 != null) list.Add(_data155);
            if (_data156 != null) list.Add(_data156);
            if (_data157 != null) list.Add(_data157);
            if (_data158 != null) list.Add(_data158);
            if (_data159 != null) list.Add(_data159);
            if (_data160 != null) list.Add(_data160);
            if (_data161 != null) list.Add(_data161);
            if (_data162 != null) list.Add(_data162);
            if (_data163 != null) list.Add(_data163);
            if (_data164 != null) list.Add(_data164);
            if (_data165 != null) list.Add(_data165);
            if (_data166 != null) list.Add(_data166);
            if (_data167 != null) list.Add(_data167);
            if (_data168 != null) list.Add(_data168);
            if (_data169 != null) list.Add(_data169);
            if (_data170 != null) list.Add(_data170);
            if (_data171 != null) list.Add(_data171);
            if (_data172 != null) list.Add(_data172);
            if (_data173 != null) list.Add(_data173);
            if (_data174 != null) list.Add(_data174);
            if (_data175 != null) list.Add(_data175);
            if (_data176 != null) list.Add(_data176);
            if (_data177 != null) list.Add(_data177);
            if (_data178 != null) list.Add(_data178);
            if (_data179 != null) list.Add(_data179);
            if (_data180 != null) list.Add(_data180);
            if (_data181 != null) list.Add(_data181);
            if (_data182 != null) list.Add(_data182);
            if (_data183 != null) list.Add(_data183);
            if (_data184 != null) list.Add(_data184);
            if (_data185 != null) list.Add(_data185);
            if (_data186 != null) list.Add(_data186);
            if (_data187 != null) list.Add(_data187);
            if (_data188 != null) list.Add(_data188);
            if (_data189 != null) list.Add(_data189);
            if (_data190 != null) list.Add(_data190);
            if (_data191 != null) list.Add(_data191);
            if (_data192 != null) list.Add(_data192);
            if (_data193 != null) list.Add(_data193);
            if (_data194 != null) list.Add(_data194);
            if (_data195 != null) list.Add(_data195);
            if (_data196 != null) list.Add(_data196);
            if (_data197 != null) list.Add(_data197);
            if (_data198 != null) list.Add(_data198);
            if (_data199 != null) list.Add(_data199);
            if (_data200 != null) list.Add(_data200);

            return list;
        }

        public List<T> GetDataList<T>() where T : DynamicData
        {
            List<T> list = new List<T>();

            if (_data001 != null) list.Add((T)_data001);
            if (_data002 != null) list.Add((T)_data002);
            if (_data003 != null) list.Add((T)_data003);
            if (_data004 != null) list.Add((T)_data004);
            if (_data005 != null) list.Add((T)_data005);
            if (_data006 != null) list.Add((T)_data006);
            if (_data007 != null) list.Add((T)_data007);
            if (_data008 != null) list.Add((T)_data008);
            if (_data009 != null) list.Add((T)_data009);
            if (_data010 != null) list.Add((T)_data010);
            if (_data011 != null) list.Add((T)_data011);
            if (_data012 != null) list.Add((T)_data012);
            if (_data013 != null) list.Add((T)_data013);
            if (_data014 != null) list.Add((T)_data014);
            if (_data015 != null) list.Add((T)_data015);
            if (_data016 != null) list.Add((T)_data016);
            if (_data017 != null) list.Add((T)_data017);
            if (_data018 != null) list.Add((T)_data018);
            if (_data019 != null) list.Add((T)_data019);
            if (_data020 != null) list.Add((T)_data020);
            if (_data021 != null) list.Add((T)_data021);
            if (_data022 != null) list.Add((T)_data022);
            if (_data023 != null) list.Add((T)_data023);
            if (_data024 != null) list.Add((T)_data024);
            if (_data025 != null) list.Add((T)_data025);
            if (_data026 != null) list.Add((T)_data026);
            if (_data027 != null) list.Add((T)_data027);
            if (_data028 != null) list.Add((T)_data028);
            if (_data029 != null) list.Add((T)_data029);
            if (_data030 != null) list.Add((T)_data030);
            if (_data031 != null) list.Add((T)_data031);
            if (_data032 != null) list.Add((T)_data032);
            if (_data033 != null) list.Add((T)_data033);
            if (_data034 != null) list.Add((T)_data034);
            if (_data035 != null) list.Add((T)_data035);
            if (_data036 != null) list.Add((T)_data036);
            if (_data037 != null) list.Add((T)_data037);
            if (_data038 != null) list.Add((T)_data038);
            if (_data039 != null) list.Add((T)_data039);
            if (_data040 != null) list.Add((T)_data040);
            if (_data041 != null) list.Add((T)_data041);
            if (_data042 != null) list.Add((T)_data042);
            if (_data043 != null) list.Add((T)_data043);
            if (_data044 != null) list.Add((T)_data044);
            if (_data045 != null) list.Add((T)_data045);
            if (_data046 != null) list.Add((T)_data046);
            if (_data047 != null) list.Add((T)_data047);
            if (_data048 != null) list.Add((T)_data048);
            if (_data049 != null) list.Add((T)_data049);
            if (_data050 != null) list.Add((T)_data050);
            if (_data051 != null) list.Add((T)_data051);
            if (_data052 != null) list.Add((T)_data052);
            if (_data053 != null) list.Add((T)_data053);
            if (_data054 != null) list.Add((T)_data054);
            if (_data055 != null) list.Add((T)_data055);
            if (_data056 != null) list.Add((T)_data056);
            if (_data057 != null) list.Add((T)_data057);
            if (_data058 != null) list.Add((T)_data058);
            if (_data059 != null) list.Add((T)_data059);
            if (_data060 != null) list.Add((T)_data060);
            if (_data061 != null) list.Add((T)_data061);
            if (_data062 != null) list.Add((T)_data062);
            if (_data063 != null) list.Add((T)_data063);
            if (_data064 != null) list.Add((T)_data064);
            if (_data065 != null) list.Add((T)_data065);
            if (_data066 != null) list.Add((T)_data066);
            if (_data067 != null) list.Add((T)_data067);
            if (_data068 != null) list.Add((T)_data068);
            if (_data069 != null) list.Add((T)_data069);
            if (_data070 != null) list.Add((T)_data070);
            if (_data071 != null) list.Add((T)_data071);
            if (_data072 != null) list.Add((T)_data072);
            if (_data073 != null) list.Add((T)_data073);
            if (_data074 != null) list.Add((T)_data074);
            if (_data075 != null) list.Add((T)_data075);
            if (_data076 != null) list.Add((T)_data076);
            if (_data077 != null) list.Add((T)_data077);
            if (_data078 != null) list.Add((T)_data078);
            if (_data079 != null) list.Add((T)_data079);
            if (_data080 != null) list.Add((T)_data080);
            if (_data081 != null) list.Add((T)_data081);
            if (_data082 != null) list.Add((T)_data082);
            if (_data083 != null) list.Add((T)_data083);
            if (_data084 != null) list.Add((T)_data084);
            if (_data085 != null) list.Add((T)_data085);
            if (_data086 != null) list.Add((T)_data086);
            if (_data087 != null) list.Add((T)_data087);
            if (_data088 != null) list.Add((T)_data088);
            if (_data089 != null) list.Add((T)_data089);
            if (_data090 != null) list.Add((T)_data090);
            if (_data091 != null) list.Add((T)_data091);
            if (_data092 != null) list.Add((T)_data092);
            if (_data093 != null) list.Add((T)_data093);
            if (_data094 != null) list.Add((T)_data094);
            if (_data095 != null) list.Add((T)_data095);
            if (_data096 != null) list.Add((T)_data096);
            if (_data097 != null) list.Add((T)_data097);
            if (_data098 != null) list.Add((T)_data098);
            if (_data099 != null) list.Add((T)_data099);
            if (_data100 != null) list.Add((T)_data100);
            if (_data101 != null) list.Add((T)_data101);
            if (_data102 != null) list.Add((T)_data102);
            if (_data103 != null) list.Add((T)_data103);
            if (_data104 != null) list.Add((T)_data104);
            if (_data105 != null) list.Add((T)_data105);
            if (_data106 != null) list.Add((T)_data106);
            if (_data107 != null) list.Add((T)_data107);
            if (_data108 != null) list.Add((T)_data108);
            if (_data109 != null) list.Add((T)_data109);
            if (_data110 != null) list.Add((T)_data110);
            if (_data111 != null) list.Add((T)_data111);
            if (_data112 != null) list.Add((T)_data112);
            if (_data113 != null) list.Add((T)_data113);
            if (_data114 != null) list.Add((T)_data114);
            if (_data115 != null) list.Add((T)_data115);
            if (_data116 != null) list.Add((T)_data116);
            if (_data117 != null) list.Add((T)_data117);
            if (_data118 != null) list.Add((T)_data118);
            if (_data119 != null) list.Add((T)_data119);
            if (_data120 != null) list.Add((T)_data120);
            if (_data121 != null) list.Add((T)_data121);
            if (_data122 != null) list.Add((T)_data122);
            if (_data123 != null) list.Add((T)_data123);
            if (_data124 != null) list.Add((T)_data124);
            if (_data125 != null) list.Add((T)_data125);
            if (_data126 != null) list.Add((T)_data126);
            if (_data127 != null) list.Add((T)_data127);
            if (_data128 != null) list.Add((T)_data128);
            if (_data129 != null) list.Add((T)_data129);
            if (_data130 != null) list.Add((T)_data130);
            if (_data131 != null) list.Add((T)_data131);
            if (_data132 != null) list.Add((T)_data132);
            if (_data133 != null) list.Add((T)_data133);
            if (_data134 != null) list.Add((T)_data134);
            if (_data135 != null) list.Add((T)_data135);
            if (_data136 != null) list.Add((T)_data136);
            if (_data137 != null) list.Add((T)_data137);
            if (_data138 != null) list.Add((T)_data138);
            if (_data139 != null) list.Add((T)_data139);
            if (_data140 != null) list.Add((T)_data140);
            if (_data141 != null) list.Add((T)_data141);
            if (_data142 != null) list.Add((T)_data142);
            if (_data143 != null) list.Add((T)_data143);
            if (_data144 != null) list.Add((T)_data144);
            if (_data145 != null) list.Add((T)_data145);
            if (_data146 != null) list.Add((T)_data146);
            if (_data147 != null) list.Add((T)_data147);
            if (_data148 != null) list.Add((T)_data148);
            if (_data149 != null) list.Add((T)_data149);
            if (_data150 != null) list.Add((T)_data150);
            if (_data151 != null) list.Add((T)_data151);
            if (_data152 != null) list.Add((T)_data152);
            if (_data153 != null) list.Add((T)_data153);
            if (_data154 != null) list.Add((T)_data154);
            if (_data155 != null) list.Add((T)_data155);
            if (_data156 != null) list.Add((T)_data156);
            if (_data157 != null) list.Add((T)_data157);
            if (_data158 != null) list.Add((T)_data158);
            if (_data159 != null) list.Add((T)_data159);
            if (_data160 != null) list.Add((T)_data160);
            if (_data161 != null) list.Add((T)_data161);
            if (_data162 != null) list.Add((T)_data162);
            if (_data163 != null) list.Add((T)_data163);
            if (_data164 != null) list.Add((T)_data164);
            if (_data165 != null) list.Add((T)_data165);
            if (_data166 != null) list.Add((T)_data166);
            if (_data167 != null) list.Add((T)_data167);
            if (_data168 != null) list.Add((T)_data168);
            if (_data169 != null) list.Add((T)_data169);
            if (_data170 != null) list.Add((T)_data170);
            if (_data171 != null) list.Add((T)_data171);
            if (_data172 != null) list.Add((T)_data172);
            if (_data173 != null) list.Add((T)_data173);
            if (_data174 != null) list.Add((T)_data174);
            if (_data175 != null) list.Add((T)_data175);
            if (_data176 != null) list.Add((T)_data176);
            if (_data177 != null) list.Add((T)_data177);
            if (_data178 != null) list.Add((T)_data178);
            if (_data179 != null) list.Add((T)_data179);
            if (_data180 != null) list.Add((T)_data180);
            if (_data181 != null) list.Add((T)_data181);
            if (_data182 != null) list.Add((T)_data182);
            if (_data183 != null) list.Add((T)_data183);
            if (_data184 != null) list.Add((T)_data184);
            if (_data185 != null) list.Add((T)_data185);
            if (_data186 != null) list.Add((T)_data186);
            if (_data187 != null) list.Add((T)_data187);
            if (_data188 != null) list.Add((T)_data188);
            if (_data189 != null) list.Add((T)_data189);
            if (_data190 != null) list.Add((T)_data190);
            if (_data191 != null) list.Add((T)_data191);
            if (_data192 != null) list.Add((T)_data192);
            if (_data193 != null) list.Add((T)_data193);
            if (_data194 != null) list.Add((T)_data194);
            if (_data195 != null) list.Add((T)_data195);
            if (_data196 != null) list.Add((T)_data196);
            if (_data197 != null) list.Add((T)_data197);
            if (_data198 != null) list.Add((T)_data198);
            if (_data199 != null) list.Add((T)_data199);
            if (_data200 != null) list.Add((T)_data200);

            return list;
        }

        #endregion

        #region GetUpdateList

        public IList GetUpdateList()
        {
            ArrayList list = new ArrayList();

            if (_data001 != null && _data001.IsChanged == true) list.Add(_data001);
            if (_data002 != null && _data002.IsChanged == true) list.Add(_data002);
            if (_data003 != null && _data003.IsChanged == true) list.Add(_data003);
            if (_data004 != null && _data004.IsChanged == true) list.Add(_data004);
            if (_data005 != null && _data005.IsChanged == true) list.Add(_data005);
            if (_data006 != null && _data006.IsChanged == true) list.Add(_data006);
            if (_data007 != null && _data007.IsChanged == true) list.Add(_data007);
            if (_data008 != null && _data008.IsChanged == true) list.Add(_data008);
            if (_data009 != null && _data009.IsChanged == true) list.Add(_data009);
            if (_data010 != null && _data010.IsChanged == true) list.Add(_data010);
            if (_data011 != null && _data011.IsChanged == true) list.Add(_data011);
            if (_data012 != null && _data012.IsChanged == true) list.Add(_data012);
            if (_data013 != null && _data013.IsChanged == true) list.Add(_data013);
            if (_data014 != null && _data014.IsChanged == true) list.Add(_data014);
            if (_data015 != null && _data015.IsChanged == true) list.Add(_data015);
            if (_data016 != null && _data016.IsChanged == true) list.Add(_data016);
            if (_data017 != null && _data017.IsChanged == true) list.Add(_data017);
            if (_data018 != null && _data018.IsChanged == true) list.Add(_data018);
            if (_data019 != null && _data019.IsChanged == true) list.Add(_data019);
            if (_data020 != null && _data020.IsChanged == true) list.Add(_data020);
            if (_data021 != null && _data021.IsChanged == true) list.Add(_data021);
            if (_data022 != null && _data022.IsChanged == true) list.Add(_data022);
            if (_data023 != null && _data023.IsChanged == true) list.Add(_data023);
            if (_data024 != null && _data024.IsChanged == true) list.Add(_data024);
            if (_data025 != null && _data025.IsChanged == true) list.Add(_data025);
            if (_data026 != null && _data026.IsChanged == true) list.Add(_data026);
            if (_data027 != null && _data027.IsChanged == true) list.Add(_data027);
            if (_data028 != null && _data028.IsChanged == true) list.Add(_data028);
            if (_data029 != null && _data029.IsChanged == true) list.Add(_data029);
            if (_data030 != null && _data030.IsChanged == true) list.Add(_data030);
            if (_data031 != null && _data031.IsChanged == true) list.Add(_data031);
            if (_data032 != null && _data032.IsChanged == true) list.Add(_data032);
            if (_data033 != null && _data033.IsChanged == true) list.Add(_data033);
            if (_data034 != null && _data034.IsChanged == true) list.Add(_data034);
            if (_data035 != null && _data035.IsChanged == true) list.Add(_data035);
            if (_data036 != null && _data036.IsChanged == true) list.Add(_data036);
            if (_data037 != null && _data037.IsChanged == true) list.Add(_data037);
            if (_data038 != null && _data038.IsChanged == true) list.Add(_data038);
            if (_data039 != null && _data039.IsChanged == true) list.Add(_data039);
            if (_data040 != null && _data040.IsChanged == true) list.Add(_data040);
            if (_data041 != null && _data041.IsChanged == true) list.Add(_data041);
            if (_data042 != null && _data042.IsChanged == true) list.Add(_data042);
            if (_data043 != null && _data043.IsChanged == true) list.Add(_data043);
            if (_data044 != null && _data044.IsChanged == true) list.Add(_data044);
            if (_data045 != null && _data045.IsChanged == true) list.Add(_data045);
            if (_data046 != null && _data046.IsChanged == true) list.Add(_data046);
            if (_data047 != null && _data047.IsChanged == true) list.Add(_data047);
            if (_data048 != null && _data048.IsChanged == true) list.Add(_data048);
            if (_data049 != null && _data049.IsChanged == true) list.Add(_data049);
            if (_data050 != null && _data050.IsChanged == true) list.Add(_data050);
            if (_data051 != null && _data051.IsChanged == true) list.Add(_data051);
            if (_data052 != null && _data052.IsChanged == true) list.Add(_data052);
            if (_data053 != null && _data053.IsChanged == true) list.Add(_data053);
            if (_data054 != null && _data054.IsChanged == true) list.Add(_data054);
            if (_data055 != null && _data055.IsChanged == true) list.Add(_data055);
            if (_data056 != null && _data056.IsChanged == true) list.Add(_data056);
            if (_data057 != null && _data057.IsChanged == true) list.Add(_data057);
            if (_data058 != null && _data058.IsChanged == true) list.Add(_data058);
            if (_data059 != null && _data059.IsChanged == true) list.Add(_data059);
            if (_data060 != null && _data060.IsChanged == true) list.Add(_data060);
            if (_data061 != null && _data061.IsChanged == true) list.Add(_data061);
            if (_data062 != null && _data062.IsChanged == true) list.Add(_data062);
            if (_data063 != null && _data063.IsChanged == true) list.Add(_data063);
            if (_data064 != null && _data064.IsChanged == true) list.Add(_data064);
            if (_data065 != null && _data065.IsChanged == true) list.Add(_data065);
            if (_data066 != null && _data066.IsChanged == true) list.Add(_data066);
            if (_data067 != null && _data067.IsChanged == true) list.Add(_data067);
            if (_data068 != null && _data068.IsChanged == true) list.Add(_data068);
            if (_data069 != null && _data069.IsChanged == true) list.Add(_data069);
            if (_data070 != null && _data070.IsChanged == true) list.Add(_data070);
            if (_data071 != null && _data071.IsChanged == true) list.Add(_data071);
            if (_data072 != null && _data072.IsChanged == true) list.Add(_data072);
            if (_data073 != null && _data073.IsChanged == true) list.Add(_data073);
            if (_data074 != null && _data074.IsChanged == true) list.Add(_data074);
            if (_data075 != null && _data075.IsChanged == true) list.Add(_data075);
            if (_data076 != null && _data076.IsChanged == true) list.Add(_data076);
            if (_data077 != null && _data077.IsChanged == true) list.Add(_data077);
            if (_data078 != null && _data078.IsChanged == true) list.Add(_data078);
            if (_data079 != null && _data079.IsChanged == true) list.Add(_data079);
            if (_data080 != null && _data080.IsChanged == true) list.Add(_data080);
            if (_data081 != null && _data081.IsChanged == true) list.Add(_data081);
            if (_data082 != null && _data082.IsChanged == true) list.Add(_data082);
            if (_data083 != null && _data083.IsChanged == true) list.Add(_data083);
            if (_data084 != null && _data084.IsChanged == true) list.Add(_data084);
            if (_data085 != null && _data085.IsChanged == true) list.Add(_data085);
            if (_data086 != null && _data086.IsChanged == true) list.Add(_data086);
            if (_data087 != null && _data087.IsChanged == true) list.Add(_data087);
            if (_data088 != null && _data088.IsChanged == true) list.Add(_data088);
            if (_data089 != null && _data089.IsChanged == true) list.Add(_data089);
            if (_data090 != null && _data090.IsChanged == true) list.Add(_data090);
            if (_data091 != null && _data091.IsChanged == true) list.Add(_data091);
            if (_data092 != null && _data092.IsChanged == true) list.Add(_data092);
            if (_data093 != null && _data093.IsChanged == true) list.Add(_data093);
            if (_data094 != null && _data094.IsChanged == true) list.Add(_data094);
            if (_data095 != null && _data095.IsChanged == true) list.Add(_data095);
            if (_data096 != null && _data096.IsChanged == true) list.Add(_data096);
            if (_data097 != null && _data097.IsChanged == true) list.Add(_data097);
            if (_data098 != null && _data098.IsChanged == true) list.Add(_data098);
            if (_data099 != null && _data099.IsChanged == true) list.Add(_data099);
            if (_data100 != null && _data100.IsChanged == true) list.Add(_data100);
            if (_data101 != null && _data101.IsChanged == true) list.Add(_data101);
            if (_data102 != null && _data102.IsChanged == true) list.Add(_data102);
            if (_data103 != null && _data103.IsChanged == true) list.Add(_data103);
            if (_data104 != null && _data104.IsChanged == true) list.Add(_data104);
            if (_data105 != null && _data105.IsChanged == true) list.Add(_data105);
            if (_data106 != null && _data106.IsChanged == true) list.Add(_data106);
            if (_data107 != null && _data107.IsChanged == true) list.Add(_data107);
            if (_data108 != null && _data108.IsChanged == true) list.Add(_data108);
            if (_data109 != null && _data109.IsChanged == true) list.Add(_data109);
            if (_data110 != null && _data110.IsChanged == true) list.Add(_data110);
            if (_data111 != null && _data111.IsChanged == true) list.Add(_data111);
            if (_data112 != null && _data112.IsChanged == true) list.Add(_data112);
            if (_data113 != null && _data113.IsChanged == true) list.Add(_data113);
            if (_data114 != null && _data114.IsChanged == true) list.Add(_data114);
            if (_data115 != null && _data115.IsChanged == true) list.Add(_data115);
            if (_data116 != null && _data116.IsChanged == true) list.Add(_data116);
            if (_data117 != null && _data117.IsChanged == true) list.Add(_data117);
            if (_data118 != null && _data118.IsChanged == true) list.Add(_data118);
            if (_data119 != null && _data119.IsChanged == true) list.Add(_data119);
            if (_data120 != null && _data120.IsChanged == true) list.Add(_data120);
            if (_data121 != null && _data121.IsChanged == true) list.Add(_data121);
            if (_data122 != null && _data122.IsChanged == true) list.Add(_data122);
            if (_data123 != null && _data123.IsChanged == true) list.Add(_data123);
            if (_data124 != null && _data124.IsChanged == true) list.Add(_data124);
            if (_data125 != null && _data125.IsChanged == true) list.Add(_data125);
            if (_data126 != null && _data126.IsChanged == true) list.Add(_data126);
            if (_data127 != null && _data127.IsChanged == true) list.Add(_data127);
            if (_data128 != null && _data128.IsChanged == true) list.Add(_data128);
            if (_data129 != null && _data129.IsChanged == true) list.Add(_data129);
            if (_data130 != null && _data130.IsChanged == true) list.Add(_data130);
            if (_data131 != null && _data131.IsChanged == true) list.Add(_data131);
            if (_data132 != null && _data132.IsChanged == true) list.Add(_data132);
            if (_data133 != null && _data133.IsChanged == true) list.Add(_data133);
            if (_data134 != null && _data134.IsChanged == true) list.Add(_data134);
            if (_data135 != null && _data135.IsChanged == true) list.Add(_data135);
            if (_data136 != null && _data136.IsChanged == true) list.Add(_data136);
            if (_data137 != null && _data137.IsChanged == true) list.Add(_data137);
            if (_data138 != null && _data138.IsChanged == true) list.Add(_data138);
            if (_data139 != null && _data139.IsChanged == true) list.Add(_data139);
            if (_data140 != null && _data140.IsChanged == true) list.Add(_data140);
            if (_data141 != null && _data141.IsChanged == true) list.Add(_data141);
            if (_data142 != null && _data142.IsChanged == true) list.Add(_data142);
            if (_data143 != null && _data143.IsChanged == true) list.Add(_data143);
            if (_data144 != null && _data144.IsChanged == true) list.Add(_data144);
            if (_data145 != null && _data145.IsChanged == true) list.Add(_data145);
            if (_data146 != null && _data146.IsChanged == true) list.Add(_data146);
            if (_data147 != null && _data147.IsChanged == true) list.Add(_data147);
            if (_data148 != null && _data148.IsChanged == true) list.Add(_data148);
            if (_data149 != null && _data149.IsChanged == true) list.Add(_data149);
            if (_data150 != null && _data150.IsChanged == true) list.Add(_data150);
            if (_data151 != null && _data151.IsChanged == true) list.Add(_data151);
            if (_data152 != null && _data152.IsChanged == true) list.Add(_data152);
            if (_data153 != null && _data153.IsChanged == true) list.Add(_data153);
            if (_data154 != null && _data154.IsChanged == true) list.Add(_data154);
            if (_data155 != null && _data155.IsChanged == true) list.Add(_data155);
            if (_data156 != null && _data156.IsChanged == true) list.Add(_data156);
            if (_data157 != null && _data157.IsChanged == true) list.Add(_data157);
            if (_data158 != null && _data158.IsChanged == true) list.Add(_data158);
            if (_data159 != null && _data159.IsChanged == true) list.Add(_data159);
            if (_data160 != null && _data160.IsChanged == true) list.Add(_data160);
            if (_data161 != null && _data161.IsChanged == true) list.Add(_data161);
            if (_data162 != null && _data162.IsChanged == true) list.Add(_data162);
            if (_data163 != null && _data163.IsChanged == true) list.Add(_data163);
            if (_data164 != null && _data164.IsChanged == true) list.Add(_data164);
            if (_data165 != null && _data165.IsChanged == true) list.Add(_data165);
            if (_data166 != null && _data166.IsChanged == true) list.Add(_data166);
            if (_data167 != null && _data167.IsChanged == true) list.Add(_data167);
            if (_data168 != null && _data168.IsChanged == true) list.Add(_data168);
            if (_data169 != null && _data169.IsChanged == true) list.Add(_data169);
            if (_data170 != null && _data170.IsChanged == true) list.Add(_data170);
            if (_data171 != null && _data171.IsChanged == true) list.Add(_data171);
            if (_data172 != null && _data172.IsChanged == true) list.Add(_data172);
            if (_data173 != null && _data173.IsChanged == true) list.Add(_data173);
            if (_data174 != null && _data174.IsChanged == true) list.Add(_data174);
            if (_data175 != null && _data175.IsChanged == true) list.Add(_data175);
            if (_data176 != null && _data176.IsChanged == true) list.Add(_data176);
            if (_data177 != null && _data177.IsChanged == true) list.Add(_data177);
            if (_data178 != null && _data178.IsChanged == true) list.Add(_data178);
            if (_data179 != null && _data179.IsChanged == true) list.Add(_data179);
            if (_data180 != null && _data180.IsChanged == true) list.Add(_data180);
            if (_data181 != null && _data181.IsChanged == true) list.Add(_data181);
            if (_data182 != null && _data182.IsChanged == true) list.Add(_data182);
            if (_data183 != null && _data183.IsChanged == true) list.Add(_data183);
            if (_data184 != null && _data184.IsChanged == true) list.Add(_data184);
            if (_data185 != null && _data185.IsChanged == true) list.Add(_data185);
            if (_data186 != null && _data186.IsChanged == true) list.Add(_data186);
            if (_data187 != null && _data187.IsChanged == true) list.Add(_data187);
            if (_data188 != null && _data188.IsChanged == true) list.Add(_data188);
            if (_data189 != null && _data189.IsChanged == true) list.Add(_data189);
            if (_data190 != null && _data190.IsChanged == true) list.Add(_data190);
            if (_data191 != null && _data191.IsChanged == true) list.Add(_data191);
            if (_data192 != null && _data192.IsChanged == true) list.Add(_data192);
            if (_data193 != null && _data193.IsChanged == true) list.Add(_data193);
            if (_data194 != null && _data194.IsChanged == true) list.Add(_data194);
            if (_data195 != null && _data195.IsChanged == true) list.Add(_data195);
            if (_data196 != null && _data196.IsChanged == true) list.Add(_data196);
            if (_data197 != null && _data197.IsChanged == true) list.Add(_data197);
            if (_data198 != null && _data198.IsChanged == true) list.Add(_data198);
            if (_data199 != null && _data199.IsChanged == true) list.Add(_data199);
            if (_data200 != null && _data200.IsChanged == true) list.Add(_data200);

            return list;
        }

        public List<T> GetUpdateList<T>() where T : DynamicData
        {
            List<T> list = new List<T>();

            if (_data001 != null && _data001.IsChanged == true) list.Add((T)_data001);
            if (_data002 != null && _data002.IsChanged == true) list.Add((T)_data002);
            if (_data003 != null && _data003.IsChanged == true) list.Add((T)_data003);
            if (_data004 != null && _data004.IsChanged == true) list.Add((T)_data004);
            if (_data005 != null && _data005.IsChanged == true) list.Add((T)_data005);
            if (_data006 != null && _data006.IsChanged == true) list.Add((T)_data006);
            if (_data007 != null && _data007.IsChanged == true) list.Add((T)_data007);
            if (_data008 != null && _data008.IsChanged == true) list.Add((T)_data008);
            if (_data009 != null && _data009.IsChanged == true) list.Add((T)_data009);
            if (_data010 != null && _data010.IsChanged == true) list.Add((T)_data010);
            if (_data011 != null && _data011.IsChanged == true) list.Add((T)_data011);
            if (_data012 != null && _data012.IsChanged == true) list.Add((T)_data012);
            if (_data013 != null && _data013.IsChanged == true) list.Add((T)_data013);
            if (_data014 != null && _data014.IsChanged == true) list.Add((T)_data014);
            if (_data015 != null && _data015.IsChanged == true) list.Add((T)_data015);
            if (_data016 != null && _data016.IsChanged == true) list.Add((T)_data016);
            if (_data017 != null && _data017.IsChanged == true) list.Add((T)_data017);
            if (_data018 != null && _data018.IsChanged == true) list.Add((T)_data018);
            if (_data019 != null && _data019.IsChanged == true) list.Add((T)_data019);
            if (_data020 != null && _data020.IsChanged == true) list.Add((T)_data020);
            if (_data021 != null && _data021.IsChanged == true) list.Add((T)_data021);
            if (_data022 != null && _data022.IsChanged == true) list.Add((T)_data022);
            if (_data023 != null && _data023.IsChanged == true) list.Add((T)_data023);
            if (_data024 != null && _data024.IsChanged == true) list.Add((T)_data024);
            if (_data025 != null && _data025.IsChanged == true) list.Add((T)_data025);
            if (_data026 != null && _data026.IsChanged == true) list.Add((T)_data026);
            if (_data027 != null && _data027.IsChanged == true) list.Add((T)_data027);
            if (_data028 != null && _data028.IsChanged == true) list.Add((T)_data028);
            if (_data029 != null && _data029.IsChanged == true) list.Add((T)_data029);
            if (_data030 != null && _data030.IsChanged == true) list.Add((T)_data030);
            if (_data031 != null && _data031.IsChanged == true) list.Add((T)_data031);
            if (_data032 != null && _data032.IsChanged == true) list.Add((T)_data032);
            if (_data033 != null && _data033.IsChanged == true) list.Add((T)_data033);
            if (_data034 != null && _data034.IsChanged == true) list.Add((T)_data034);
            if (_data035 != null && _data035.IsChanged == true) list.Add((T)_data035);
            if (_data036 != null && _data036.IsChanged == true) list.Add((T)_data036);
            if (_data037 != null && _data037.IsChanged == true) list.Add((T)_data037);
            if (_data038 != null && _data038.IsChanged == true) list.Add((T)_data038);
            if (_data039 != null && _data039.IsChanged == true) list.Add((T)_data039);
            if (_data040 != null && _data040.IsChanged == true) list.Add((T)_data040);
            if (_data041 != null && _data041.IsChanged == true) list.Add((T)_data041);
            if (_data042 != null && _data042.IsChanged == true) list.Add((T)_data042);
            if (_data043 != null && _data043.IsChanged == true) list.Add((T)_data043);
            if (_data044 != null && _data044.IsChanged == true) list.Add((T)_data044);
            if (_data045 != null && _data045.IsChanged == true) list.Add((T)_data045);
            if (_data046 != null && _data046.IsChanged == true) list.Add((T)_data046);
            if (_data047 != null && _data047.IsChanged == true) list.Add((T)_data047);
            if (_data048 != null && _data048.IsChanged == true) list.Add((T)_data048);
            if (_data049 != null && _data049.IsChanged == true) list.Add((T)_data049);
            if (_data050 != null && _data050.IsChanged == true) list.Add((T)_data050);
            if (_data051 != null && _data051.IsChanged == true) list.Add((T)_data051);
            if (_data052 != null && _data052.IsChanged == true) list.Add((T)_data052);
            if (_data053 != null && _data053.IsChanged == true) list.Add((T)_data053);
            if (_data054 != null && _data054.IsChanged == true) list.Add((T)_data054);
            if (_data055 != null && _data055.IsChanged == true) list.Add((T)_data055);
            if (_data056 != null && _data056.IsChanged == true) list.Add((T)_data056);
            if (_data057 != null && _data057.IsChanged == true) list.Add((T)_data057);
            if (_data058 != null && _data058.IsChanged == true) list.Add((T)_data058);
            if (_data059 != null && _data059.IsChanged == true) list.Add((T)_data059);
            if (_data060 != null && _data060.IsChanged == true) list.Add((T)_data060);
            if (_data061 != null && _data061.IsChanged == true) list.Add((T)_data061);
            if (_data062 != null && _data062.IsChanged == true) list.Add((T)_data062);
            if (_data063 != null && _data063.IsChanged == true) list.Add((T)_data063);
            if (_data064 != null && _data064.IsChanged == true) list.Add((T)_data064);
            if (_data065 != null && _data065.IsChanged == true) list.Add((T)_data065);
            if (_data066 != null && _data066.IsChanged == true) list.Add((T)_data066);
            if (_data067 != null && _data067.IsChanged == true) list.Add((T)_data067);
            if (_data068 != null && _data068.IsChanged == true) list.Add((T)_data068);
            if (_data069 != null && _data069.IsChanged == true) list.Add((T)_data069);
            if (_data070 != null && _data070.IsChanged == true) list.Add((T)_data070);
            if (_data071 != null && _data071.IsChanged == true) list.Add((T)_data071);
            if (_data072 != null && _data072.IsChanged == true) list.Add((T)_data072);
            if (_data073 != null && _data073.IsChanged == true) list.Add((T)_data073);
            if (_data074 != null && _data074.IsChanged == true) list.Add((T)_data074);
            if (_data075 != null && _data075.IsChanged == true) list.Add((T)_data075);
            if (_data076 != null && _data076.IsChanged == true) list.Add((T)_data076);
            if (_data077 != null && _data077.IsChanged == true) list.Add((T)_data077);
            if (_data078 != null && _data078.IsChanged == true) list.Add((T)_data078);
            if (_data079 != null && _data079.IsChanged == true) list.Add((T)_data079);
            if (_data080 != null && _data080.IsChanged == true) list.Add((T)_data080);
            if (_data081 != null && _data081.IsChanged == true) list.Add((T)_data081);
            if (_data082 != null && _data082.IsChanged == true) list.Add((T)_data082);
            if (_data083 != null && _data083.IsChanged == true) list.Add((T)_data083);
            if (_data084 != null && _data084.IsChanged == true) list.Add((T)_data084);
            if (_data085 != null && _data085.IsChanged == true) list.Add((T)_data085);
            if (_data086 != null && _data086.IsChanged == true) list.Add((T)_data086);
            if (_data087 != null && _data087.IsChanged == true) list.Add((T)_data087);
            if (_data088 != null && _data088.IsChanged == true) list.Add((T)_data088);
            if (_data089 != null && _data089.IsChanged == true) list.Add((T)_data089);
            if (_data090 != null && _data090.IsChanged == true) list.Add((T)_data090);
            if (_data091 != null && _data091.IsChanged == true) list.Add((T)_data091);
            if (_data092 != null && _data092.IsChanged == true) list.Add((T)_data092);
            if (_data093 != null && _data093.IsChanged == true) list.Add((T)_data093);
            if (_data094 != null && _data094.IsChanged == true) list.Add((T)_data094);
            if (_data095 != null && _data095.IsChanged == true) list.Add((T)_data095);
            if (_data096 != null && _data096.IsChanged == true) list.Add((T)_data096);
            if (_data097 != null && _data097.IsChanged == true) list.Add((T)_data097);
            if (_data098 != null && _data098.IsChanged == true) list.Add((T)_data098);
            if (_data099 != null && _data099.IsChanged == true) list.Add((T)_data099);
            if (_data100 != null && _data100.IsChanged == true) list.Add((T)_data100);
            if (_data101 != null && _data101.IsChanged == true) list.Add((T)_data101);
            if (_data102 != null && _data102.IsChanged == true) list.Add((T)_data102);
            if (_data103 != null && _data103.IsChanged == true) list.Add((T)_data103);
            if (_data104 != null && _data104.IsChanged == true) list.Add((T)_data104);
            if (_data105 != null && _data105.IsChanged == true) list.Add((T)_data105);
            if (_data106 != null && _data106.IsChanged == true) list.Add((T)_data106);
            if (_data107 != null && _data107.IsChanged == true) list.Add((T)_data107);
            if (_data108 != null && _data108.IsChanged == true) list.Add((T)_data108);
            if (_data109 != null && _data109.IsChanged == true) list.Add((T)_data109);
            if (_data110 != null && _data110.IsChanged == true) list.Add((T)_data110);
            if (_data111 != null && _data111.IsChanged == true) list.Add((T)_data111);
            if (_data112 != null && _data112.IsChanged == true) list.Add((T)_data112);
            if (_data113 != null && _data113.IsChanged == true) list.Add((T)_data113);
            if (_data114 != null && _data114.IsChanged == true) list.Add((T)_data114);
            if (_data115 != null && _data115.IsChanged == true) list.Add((T)_data115);
            if (_data116 != null && _data116.IsChanged == true) list.Add((T)_data116);
            if (_data117 != null && _data117.IsChanged == true) list.Add((T)_data117);
            if (_data118 != null && _data118.IsChanged == true) list.Add((T)_data118);
            if (_data119 != null && _data119.IsChanged == true) list.Add((T)_data119);
            if (_data120 != null && _data120.IsChanged == true) list.Add((T)_data120);
            if (_data121 != null && _data121.IsChanged == true) list.Add((T)_data121);
            if (_data122 != null && _data122.IsChanged == true) list.Add((T)_data122);
            if (_data123 != null && _data123.IsChanged == true) list.Add((T)_data123);
            if (_data124 != null && _data124.IsChanged == true) list.Add((T)_data124);
            if (_data125 != null && _data125.IsChanged == true) list.Add((T)_data125);
            if (_data126 != null && _data126.IsChanged == true) list.Add((T)_data126);
            if (_data127 != null && _data127.IsChanged == true) list.Add((T)_data127);
            if (_data128 != null && _data128.IsChanged == true) list.Add((T)_data128);
            if (_data129 != null && _data129.IsChanged == true) list.Add((T)_data129);
            if (_data130 != null && _data130.IsChanged == true) list.Add((T)_data130);
            if (_data131 != null && _data131.IsChanged == true) list.Add((T)_data131);
            if (_data132 != null && _data132.IsChanged == true) list.Add((T)_data132);
            if (_data133 != null && _data133.IsChanged == true) list.Add((T)_data133);
            if (_data134 != null && _data134.IsChanged == true) list.Add((T)_data134);
            if (_data135 != null && _data135.IsChanged == true) list.Add((T)_data135);
            if (_data136 != null && _data136.IsChanged == true) list.Add((T)_data136);
            if (_data137 != null && _data137.IsChanged == true) list.Add((T)_data137);
            if (_data138 != null && _data138.IsChanged == true) list.Add((T)_data138);
            if (_data139 != null && _data139.IsChanged == true) list.Add((T)_data139);
            if (_data140 != null && _data140.IsChanged == true) list.Add((T)_data140);
            if (_data141 != null && _data141.IsChanged == true) list.Add((T)_data141);
            if (_data142 != null && _data142.IsChanged == true) list.Add((T)_data142);
            if (_data143 != null && _data143.IsChanged == true) list.Add((T)_data143);
            if (_data144 != null && _data144.IsChanged == true) list.Add((T)_data144);
            if (_data145 != null && _data145.IsChanged == true) list.Add((T)_data145);
            if (_data146 != null && _data146.IsChanged == true) list.Add((T)_data146);
            if (_data147 != null && _data147.IsChanged == true) list.Add((T)_data147);
            if (_data148 != null && _data148.IsChanged == true) list.Add((T)_data148);
            if (_data149 != null && _data149.IsChanged == true) list.Add((T)_data149);
            if (_data150 != null && _data150.IsChanged == true) list.Add((T)_data150);
            if (_data151 != null && _data151.IsChanged == true) list.Add((T)_data151);
            if (_data152 != null && _data152.IsChanged == true) list.Add((T)_data152);
            if (_data153 != null && _data153.IsChanged == true) list.Add((T)_data153);
            if (_data154 != null && _data154.IsChanged == true) list.Add((T)_data154);
            if (_data155 != null && _data155.IsChanged == true) list.Add((T)_data155);
            if (_data156 != null && _data156.IsChanged == true) list.Add((T)_data156);
            if (_data157 != null && _data157.IsChanged == true) list.Add((T)_data157);
            if (_data158 != null && _data158.IsChanged == true) list.Add((T)_data158);
            if (_data159 != null && _data159.IsChanged == true) list.Add((T)_data159);
            if (_data160 != null && _data160.IsChanged == true) list.Add((T)_data160);
            if (_data161 != null && _data161.IsChanged == true) list.Add((T)_data161);
            if (_data162 != null && _data162.IsChanged == true) list.Add((T)_data162);
            if (_data163 != null && _data163.IsChanged == true) list.Add((T)_data163);
            if (_data164 != null && _data164.IsChanged == true) list.Add((T)_data164);
            if (_data165 != null && _data165.IsChanged == true) list.Add((T)_data165);
            if (_data166 != null && _data166.IsChanged == true) list.Add((T)_data166);
            if (_data167 != null && _data167.IsChanged == true) list.Add((T)_data167);
            if (_data168 != null && _data168.IsChanged == true) list.Add((T)_data168);
            if (_data169 != null && _data169.IsChanged == true) list.Add((T)_data169);
            if (_data170 != null && _data170.IsChanged == true) list.Add((T)_data170);
            if (_data171 != null && _data171.IsChanged == true) list.Add((T)_data171);
            if (_data172 != null && _data172.IsChanged == true) list.Add((T)_data172);
            if (_data173 != null && _data173.IsChanged == true) list.Add((T)_data173);
            if (_data174 != null && _data174.IsChanged == true) list.Add((T)_data174);
            if (_data175 != null && _data175.IsChanged == true) list.Add((T)_data175);
            if (_data176 != null && _data176.IsChanged == true) list.Add((T)_data176);
            if (_data177 != null && _data177.IsChanged == true) list.Add((T)_data177);
            if (_data178 != null && _data178.IsChanged == true) list.Add((T)_data178);
            if (_data179 != null && _data179.IsChanged == true) list.Add((T)_data179);
            if (_data180 != null && _data180.IsChanged == true) list.Add((T)_data180);
            if (_data181 != null && _data181.IsChanged == true) list.Add((T)_data181);
            if (_data182 != null && _data182.IsChanged == true) list.Add((T)_data182);
            if (_data183 != null && _data183.IsChanged == true) list.Add((T)_data183);
            if (_data184 != null && _data184.IsChanged == true) list.Add((T)_data184);
            if (_data185 != null && _data185.IsChanged == true) list.Add((T)_data185);
            if (_data186 != null && _data186.IsChanged == true) list.Add((T)_data186);
            if (_data187 != null && _data187.IsChanged == true) list.Add((T)_data187);
            if (_data188 != null && _data188.IsChanged == true) list.Add((T)_data188);
            if (_data189 != null && _data189.IsChanged == true) list.Add((T)_data189);
            if (_data190 != null && _data190.IsChanged == true) list.Add((T)_data190);
            if (_data191 != null && _data191.IsChanged == true) list.Add((T)_data191);
            if (_data192 != null && _data192.IsChanged == true) list.Add((T)_data192);
            if (_data193 != null && _data193.IsChanged == true) list.Add((T)_data193);
            if (_data194 != null && _data194.IsChanged == true) list.Add((T)_data194);
            if (_data195 != null && _data195.IsChanged == true) list.Add((T)_data195);
            if (_data196 != null && _data196.IsChanged == true) list.Add((T)_data196);
            if (_data197 != null && _data197.IsChanged == true) list.Add((T)_data197);
            if (_data198 != null && _data198.IsChanged == true) list.Add((T)_data198);
            if (_data199 != null && _data199.IsChanged == true) list.Add((T)_data199);
            if (_data200 != null && _data200.IsChanged == true) list.Add((T)_data200);

            return list;
        }

        #endregion


        public void SetDynamicData(int index, DynamicData data)
        {
            data.IsChanged = false;
            switch (index)
            {
                case 001: _data001 = data; break;
                case 002: _data002 = data; break;
                case 003: _data003 = data; break;
                case 004: _data004 = data; break;
                case 005: _data005 = data; break;
                case 006: _data006 = data; break;
                case 007: _data007 = data; break;
                case 008: _data008 = data; break;
                case 009: _data009 = data; break;
                case 010: _data010 = data; break;
                case 011: _data011 = data; break;
                case 012: _data012 = data; break;
                case 013: _data013 = data; break;
                case 014: _data014 = data; break;
                case 015: _data015 = data; break;
                case 016: _data016 = data; break;
                case 017: _data017 = data; break;
                case 018: _data018 = data; break;
                case 019: _data019 = data; break;
                case 020: _data020 = data; break;
                case 021: _data021 = data; break;
                case 022: _data022 = data; break;
                case 023: _data023 = data; break;
                case 024: _data024 = data; break;
                case 025: _data025 = data; break;
                case 026: _data026 = data; break;
                case 027: _data027 = data; break;
                case 028: _data028 = data; break;
                case 029: _data029 = data; break;
                case 030: _data030 = data; break;
                case 031: _data031 = data; break;
                case 032: _data032 = data; break;
                case 033: _data033 = data; break;
                case 034: _data034 = data; break;
                case 035: _data035 = data; break;
                case 036: _data036 = data; break;
                case 037: _data037 = data; break;
                case 038: _data038 = data; break;
                case 039: _data039 = data; break;
                case 040: _data040 = data; break;
                case 041: _data041 = data; break;
                case 042: _data042 = data; break;
                case 043: _data043 = data; break;
                case 044: _data044 = data; break;
                case 045: _data045 = data; break;
                case 046: _data046 = data; break;
                case 047: _data047 = data; break;
                case 048: _data048 = data; break;
                case 049: _data049 = data; break;
                case 050: _data050 = data; break;
                case 051: _data051 = data; break;
                case 052: _data052 = data; break;
                case 053: _data053 = data; break;
                case 054: _data054 = data; break;
                case 055: _data055 = data; break;
                case 056: _data056 = data; break;
                case 057: _data057 = data; break;
                case 058: _data058 = data; break;
                case 059: _data059 = data; break;
                case 060: _data060 = data; break;
                case 061: _data061 = data; break;
                case 062: _data062 = data; break;
                case 063: _data063 = data; break;
                case 064: _data064 = data; break;
                case 065: _data065 = data; break;
                case 066: _data066 = data; break;
                case 067: _data067 = data; break;
                case 068: _data068 = data; break;
                case 069: _data069 = data; break;
                case 070: _data070 = data; break;
                case 071: _data071 = data; break;
                case 072: _data072 = data; break;
                case 073: _data073 = data; break;
                case 074: _data074 = data; break;
                case 075: _data075 = data; break;
                case 076: _data076 = data; break;
                case 077: _data077 = data; break;
                case 078: _data078 = data; break;
                case 079: _data079 = data; break;
                case 080: _data080 = data; break;
                case 081: _data081 = data; break;
                case 082: _data082 = data; break;
                case 083: _data083 = data; break;
                case 084: _data084 = data; break;
                case 085: _data085 = data; break;
                case 086: _data086 = data; break;
                case 087: _data087 = data; break;
                case 088: _data088 = data; break;
                case 089: _data089 = data; break;
                case 090: _data090 = data; break;
                case 091: _data091 = data; break;
                case 092: _data092 = data; break;
                case 093: _data093 = data; break;
                case 094: _data094 = data; break;
                case 095: _data095 = data; break;
                case 096: _data096 = data; break;
                case 097: _data097 = data; break;
                case 098: _data098 = data; break;
                case 099: _data099 = data; break;
                case 100: _data100 = data; break;
                case 101: _data101 = data; break;
                case 102: _data102 = data; break;
                case 103: _data103 = data; break;
                case 104: _data104 = data; break;
                case 105: _data105 = data; break;
                case 106: _data106 = data; break;
                case 107: _data107 = data; break;
                case 108: _data108 = data; break;
                case 109: _data109 = data; break;
                case 110: _data110 = data; break;
                case 111: _data111 = data; break;
                case 112: _data112 = data; break;
                case 113: _data113 = data; break;
                case 114: _data114 = data; break;
                case 115: _data115 = data; break;
                case 116: _data116 = data; break;
                case 117: _data117 = data; break;
                case 118: _data118 = data; break;
                case 119: _data119 = data; break;
                case 120: _data120 = data; break;
                case 121: _data121 = data; break;
                case 122: _data122 = data; break;
                case 123: _data123 = data; break;
                case 124: _data124 = data; break;
                case 125: _data125 = data; break;
                case 126: _data126 = data; break;
                case 127: _data127 = data; break;
                case 128: _data128 = data; break;
                case 129: _data129 = data; break;
                case 130: _data130 = data; break;
                case 131: _data131 = data; break;
                case 132: _data132 = data; break;
                case 133: _data133 = data; break;
                case 134: _data134 = data; break;
                case 135: _data135 = data; break;
                case 136: _data136 = data; break;
                case 137: _data137 = data; break;
                case 138: _data138 = data; break;
                case 139: _data139 = data; break;
                case 140: _data140 = data; break;
                case 141: _data141 = data; break;
                case 142: _data142 = data; break;
                case 143: _data143 = data; break;
                case 144: _data144 = data; break;
                case 145: _data145 = data; break;
                case 146: _data146 = data; break;
                case 147: _data147 = data; break;
                case 148: _data148 = data; break;
                case 149: _data149 = data; break;
                case 150: _data150 = data; break;
                case 151: _data151 = data; break;
                case 152: _data152 = data; break;
                case 153: _data153 = data; break;
                case 154: _data154 = data; break;
                case 155: _data155 = data; break;
                case 156: _data156 = data; break;
                case 157: _data157 = data; break;
                case 158: _data158 = data; break;
                case 159: _data159 = data; break;
                case 160: _data160 = data; break;
                case 161: _data161 = data; break;
                case 162: _data162 = data; break;
                case 163: _data163 = data; break;
                case 164: _data164 = data; break;
                case 165: _data165 = data; break;
                case 166: _data166 = data; break;
                case 167: _data167 = data; break;
                case 168: _data168 = data; break;
                case 169: _data169 = data; break;
                case 170: _data170 = data; break;
                case 171: _data171 = data; break;
                case 172: _data172 = data; break;
                case 173: _data173 = data; break;
                case 174: _data174 = data; break;
                case 175: _data175 = data; break;
                case 176: _data176 = data; break;
                case 177: _data177 = data; break;
                case 178: _data178 = data; break;
                case 179: _data179 = data; break;
                case 180: _data180 = data; break;
                case 181: _data181 = data; break;
                case 182: _data182 = data; break;
                case 183: _data183 = data; break;
                case 184: _data184 = data; break;
                case 185: _data185 = data; break;
                case 186: _data186 = data; break;
                case 187: _data187 = data; break;
                case 188: _data188 = data; break;
                case 189: _data189 = data; break;
                case 190: _data190 = data; break;
                case 191: _data191 = data; break;
                case 192: _data192 = data; break;
                case 193: _data193 = data; break;
                case 194: _data194 = data; break;
                case 195: _data195 = data; break;
                case 196: _data196 = data; break;
                case 197: _data197 = data; break;
                case 198: _data198 = data; break;
                case 199: _data199 = data; break;
                case 200: _data200 = data; break;
                default: break;
            }
        }

        public DynamicData GetDynamicData(int index)
        {
            switch (index)
            {
                case 001: return _data001;
                case 002: return _data002;
                case 003: return _data003;
                case 004: return _data004;
                case 005: return _data005;
                case 006: return _data006;
                case 007: return _data007;
                case 008: return _data008;
                case 009: return _data009;
                case 010: return _data010;
                case 011: return _data011;
                case 012: return _data012;
                case 013: return _data013;
                case 014: return _data014;
                case 015: return _data015;
                case 016: return _data016;
                case 017: return _data017;
                case 018: return _data018;
                case 019: return _data019;
                case 020: return _data020;
                case 021: return _data021;
                case 022: return _data022;
                case 023: return _data023;
                case 024: return _data024;
                case 025: return _data025;
                case 026: return _data026;
                case 027: return _data027;
                case 028: return _data028;
                case 029: return _data029;
                case 030: return _data030;
                case 031: return _data031;
                case 032: return _data032;
                case 033: return _data033;
                case 034: return _data034;
                case 035: return _data035;
                case 036: return _data036;
                case 037: return _data037;
                case 038: return _data038;
                case 039: return _data039;
                case 040: return _data040;
                case 041: return _data041;
                case 042: return _data042;
                case 043: return _data043;
                case 044: return _data044;
                case 045: return _data045;
                case 046: return _data046;
                case 047: return _data047;
                case 048: return _data048;
                case 049: return _data049;
                case 050: return _data050;
                case 051: return _data051;
                case 052: return _data052;
                case 053: return _data053;
                case 054: return _data054;
                case 055: return _data055;
                case 056: return _data056;
                case 057: return _data057;
                case 058: return _data058;
                case 059: return _data059;
                case 060: return _data060;
                case 061: return _data061;
                case 062: return _data062;
                case 063: return _data063;
                case 064: return _data064;
                case 065: return _data065;
                case 066: return _data066;
                case 067: return _data067;
                case 068: return _data068;
                case 069: return _data069;
                case 070: return _data070;
                case 071: return _data071;
                case 072: return _data072;
                case 073: return _data073;
                case 074: return _data074;
                case 075: return _data075;
                case 076: return _data076;
                case 077: return _data077;
                case 078: return _data078;
                case 079: return _data079;
                case 080: return _data080;
                case 081: return _data081;
                case 082: return _data082;
                case 083: return _data083;
                case 084: return _data084;
                case 085: return _data085;
                case 086: return _data086;
                case 087: return _data087;
                case 088: return _data088;
                case 089: return _data089;
                case 090: return _data090;
                case 091: return _data091;
                case 092: return _data092;
                case 093: return _data093;
                case 094: return _data094;
                case 095: return _data095;
                case 096: return _data096;
                case 097: return _data097;
                case 098: return _data098;
                case 099: return _data099;
                case 100: return _data100;
                case 101: return _data101;
                case 102: return _data102;
                case 103: return _data103;
                case 104: return _data104;
                case 105: return _data105;
                case 106: return _data106;
                case 107: return _data107;
                case 108: return _data108;
                case 109: return _data109;
                case 110: return _data110;
                case 111: return _data111;
                case 112: return _data112;
                case 113: return _data113;
                case 114: return _data114;
                case 115: return _data115;
                case 116: return _data116;
                case 117: return _data117;
                case 118: return _data118;
                case 119: return _data119;
                case 120: return _data120;
                case 121: return _data121;
                case 122: return _data122;
                case 123: return _data123;
                case 124: return _data124;
                case 125: return _data125;
                case 126: return _data126;
                case 127: return _data127;
                case 128: return _data128;
                case 129: return _data129;
                case 130: return _data130;
                case 131: return _data131;
                case 132: return _data132;
                case 133: return _data133;
                case 134: return _data134;
                case 135: return _data135;
                case 136: return _data136;
                case 137: return _data137;
                case 138: return _data138;
                case 139: return _data139;
                case 140: return _data140;
                case 141: return _data141;
                case 142: return _data142;
                case 143: return _data143;
                case 144: return _data144;
                case 145: return _data145;
                case 146: return _data146;
                case 147: return _data147;
                case 148: return _data148;
                case 149: return _data149;
                case 150: return _data150;
                case 151: return _data151;
                case 152: return _data152;
                case 153: return _data153;
                case 154: return _data154;
                case 155: return _data155;
                case 156: return _data156;
                case 157: return _data157;
                case 158: return _data158;
                case 159: return _data159;
                case 160: return _data160;
                case 161: return _data161;
                case 162: return _data162;
                case 163: return _data163;
                case 164: return _data164;
                case 165: return _data165;
                case 166: return _data166;
                case 167: return _data167;
                case 168: return _data168;
                case 169: return _data169;
                case 170: return _data170;
                case 171: return _data171;
                case 172: return _data172;
                case 173: return _data173;
                case 174: return _data174;
                case 175: return _data175;
                case 176: return _data176;
                case 177: return _data177;
                case 178: return _data178;
                case 179: return _data179;
                case 180: return _data180;
                case 181: return _data181;
                case 182: return _data182;
                case 183: return _data183;
                case 184: return _data184;
                case 185: return _data185;
                case 186: return _data186;
                case 187: return _data187;
                case 188: return _data188;
                case 189: return _data189;
                case 190: return _data190;
                case 191: return _data191;
                case 192: return _data192;
                case 193: return _data193;
                case 194: return _data194;
                case 195: return _data195;
                case 196: return _data196;
                case 197: return _data197;
                case 198: return _data198;
                case 199: return _data199;
                case 200: return _data200;
                default: return null;
            }
            return null;
        }
        public void ClearDataStatus()
        {
            this.IsDeleted = false;
            if (_data001 != null) _data001.IsChanged = false;
            if (_data002 != null) _data002.IsChanged = false;
            if (_data003 != null) _data003.IsChanged = false;
            if (_data004 != null) _data004.IsChanged = false;
            if (_data005 != null) _data005.IsChanged = false;
            if (_data006 != null) _data006.IsChanged = false;
            if (_data007 != null) _data007.IsChanged = false;
            if (_data008 != null) _data008.IsChanged = false;
            if (_data009 != null) _data009.IsChanged = false;
            if (_data010 != null) _data010.IsChanged = false;
            if (_data011 != null) _data011.IsChanged = false;
            if (_data012 != null) _data012.IsChanged = false;
            if (_data013 != null) _data013.IsChanged = false;
            if (_data014 != null) _data014.IsChanged = false;
            if (_data015 != null) _data015.IsChanged = false;
            if (_data016 != null) _data016.IsChanged = false;
            if (_data017 != null) _data017.IsChanged = false;
            if (_data018 != null) _data018.IsChanged = false;
            if (_data019 != null) _data019.IsChanged = false;
            if (_data020 != null) _data020.IsChanged = false;
            if (_data021 != null) _data021.IsChanged = false;
            if (_data022 != null) _data022.IsChanged = false;
            if (_data023 != null) _data023.IsChanged = false;
            if (_data024 != null) _data024.IsChanged = false;
            if (_data025 != null) _data025.IsChanged = false;
            if (_data026 != null) _data026.IsChanged = false;
            if (_data027 != null) _data027.IsChanged = false;
            if (_data028 != null) _data028.IsChanged = false;
            if (_data029 != null) _data029.IsChanged = false;
            if (_data030 != null) _data030.IsChanged = false;
            if (_data031 != null) _data031.IsChanged = false;
            if (_data032 != null) _data032.IsChanged = false;
            if (_data033 != null) _data033.IsChanged = false;
            if (_data034 != null) _data034.IsChanged = false;
            if (_data035 != null) _data035.IsChanged = false;
            if (_data036 != null) _data036.IsChanged = false;
            if (_data037 != null) _data037.IsChanged = false;
            if (_data038 != null) _data038.IsChanged = false;
            if (_data039 != null) _data039.IsChanged = false;
            if (_data040 != null) _data040.IsChanged = false;
            if (_data041 != null) _data041.IsChanged = false;
            if (_data042 != null) _data042.IsChanged = false;
            if (_data043 != null) _data043.IsChanged = false;
            if (_data044 != null) _data044.IsChanged = false;
            if (_data045 != null) _data045.IsChanged = false;
            if (_data046 != null) _data046.IsChanged = false;
            if (_data047 != null) _data047.IsChanged = false;
            if (_data048 != null) _data048.IsChanged = false;
            if (_data049 != null) _data049.IsChanged = false;
            if (_data050 != null) _data050.IsChanged = false;
            if (_data051 != null) _data051.IsChanged = false;
            if (_data052 != null) _data052.IsChanged = false;
            if (_data053 != null) _data053.IsChanged = false;
            if (_data054 != null) _data054.IsChanged = false;
            if (_data055 != null) _data055.IsChanged = false;
            if (_data056 != null) _data056.IsChanged = false;
            if (_data057 != null) _data057.IsChanged = false;
            if (_data058 != null) _data058.IsChanged = false;
            if (_data059 != null) _data059.IsChanged = false;
            if (_data060 != null) _data060.IsChanged = false;
            if (_data061 != null) _data061.IsChanged = false;
            if (_data062 != null) _data062.IsChanged = false;
            if (_data063 != null) _data063.IsChanged = false;
            if (_data064 != null) _data064.IsChanged = false;
            if (_data065 != null) _data065.IsChanged = false;
            if (_data066 != null) _data066.IsChanged = false;
            if (_data067 != null) _data067.IsChanged = false;
            if (_data068 != null) _data068.IsChanged = false;
            if (_data069 != null) _data069.IsChanged = false;
            if (_data070 != null) _data070.IsChanged = false;
            if (_data071 != null) _data071.IsChanged = false;
            if (_data072 != null) _data072.IsChanged = false;
            if (_data073 != null) _data073.IsChanged = false;
            if (_data074 != null) _data074.IsChanged = false;
            if (_data075 != null) _data075.IsChanged = false;
            if (_data076 != null) _data076.IsChanged = false;
            if (_data077 != null) _data077.IsChanged = false;
            if (_data078 != null) _data078.IsChanged = false;
            if (_data079 != null) _data079.IsChanged = false;
            if (_data080 != null) _data080.IsChanged = false;
            if (_data081 != null) _data081.IsChanged = false;
            if (_data082 != null) _data082.IsChanged = false;
            if (_data083 != null) _data083.IsChanged = false;
            if (_data084 != null) _data084.IsChanged = false;
            if (_data085 != null) _data085.IsChanged = false;
            if (_data086 != null) _data086.IsChanged = false;
            if (_data087 != null) _data087.IsChanged = false;
            if (_data088 != null) _data088.IsChanged = false;
            if (_data089 != null) _data089.IsChanged = false;
            if (_data090 != null) _data090.IsChanged = false;
            if (_data091 != null) _data091.IsChanged = false;
            if (_data092 != null) _data092.IsChanged = false;
            if (_data093 != null) _data093.IsChanged = false;
            if (_data094 != null) _data094.IsChanged = false;
            if (_data095 != null) _data095.IsChanged = false;
            if (_data096 != null) _data096.IsChanged = false;
            if (_data097 != null) _data097.IsChanged = false;
            if (_data098 != null) _data098.IsChanged = false;
            if (_data099 != null) _data099.IsChanged = false;
            if (_data100 != null) _data100.IsChanged = false;
            if (_data101 != null) _data101.IsChanged = false;
            if (_data102 != null) _data102.IsChanged = false;
            if (_data103 != null) _data103.IsChanged = false;
            if (_data104 != null) _data104.IsChanged = false;
            if (_data105 != null) _data105.IsChanged = false;
            if (_data106 != null) _data106.IsChanged = false;
            if (_data107 != null) _data107.IsChanged = false;
            if (_data108 != null) _data108.IsChanged = false;
            if (_data109 != null) _data109.IsChanged = false;
            if (_data110 != null) _data110.IsChanged = false;
            if (_data111 != null) _data111.IsChanged = false;
            if (_data112 != null) _data112.IsChanged = false;
            if (_data113 != null) _data113.IsChanged = false;
            if (_data114 != null) _data114.IsChanged = false;
            if (_data115 != null) _data115.IsChanged = false;
            if (_data116 != null) _data116.IsChanged = false;
            if (_data117 != null) _data117.IsChanged = false;
            if (_data118 != null) _data118.IsChanged = false;
            if (_data119 != null) _data119.IsChanged = false;
            if (_data120 != null) _data120.IsChanged = false;
            if (_data121 != null) _data121.IsChanged = false;
            if (_data122 != null) _data122.IsChanged = false;
            if (_data123 != null) _data123.IsChanged = false;
            if (_data124 != null) _data124.IsChanged = false;
            if (_data125 != null) _data125.IsChanged = false;
            if (_data126 != null) _data126.IsChanged = false;
            if (_data127 != null) _data127.IsChanged = false;
            if (_data128 != null) _data128.IsChanged = false;
            if (_data129 != null) _data129.IsChanged = false;
            if (_data130 != null) _data130.IsChanged = false;
            if (_data131 != null) _data131.IsChanged = false;
            if (_data132 != null) _data132.IsChanged = false;
            if (_data133 != null) _data133.IsChanged = false;
            if (_data134 != null) _data134.IsChanged = false;
            if (_data135 != null) _data135.IsChanged = false;
            if (_data136 != null) _data136.IsChanged = false;
            if (_data137 != null) _data137.IsChanged = false;
            if (_data138 != null) _data138.IsChanged = false;
            if (_data139 != null) _data139.IsChanged = false;
            if (_data140 != null) _data140.IsChanged = false;
            if (_data141 != null) _data141.IsChanged = false;
            if (_data142 != null) _data142.IsChanged = false;
            if (_data143 != null) _data143.IsChanged = false;
            if (_data144 != null) _data144.IsChanged = false;
            if (_data145 != null) _data145.IsChanged = false;
            if (_data146 != null) _data146.IsChanged = false;
            if (_data147 != null) _data147.IsChanged = false;
            if (_data148 != null) _data148.IsChanged = false;
            if (_data149 != null) _data149.IsChanged = false;
            if (_data150 != null) _data150.IsChanged = false;
            if (_data151 != null) _data151.IsChanged = false;
            if (_data152 != null) _data152.IsChanged = false;
            if (_data153 != null) _data153.IsChanged = false;
            if (_data154 != null) _data154.IsChanged = false;
            if (_data155 != null) _data155.IsChanged = false;
            if (_data156 != null) _data156.IsChanged = false;
            if (_data157 != null) _data157.IsChanged = false;
            if (_data158 != null) _data158.IsChanged = false;
            if (_data159 != null) _data159.IsChanged = false;
            if (_data160 != null) _data160.IsChanged = false;
            if (_data161 != null) _data161.IsChanged = false;
            if (_data162 != null) _data162.IsChanged = false;
            if (_data163 != null) _data163.IsChanged = false;
            if (_data164 != null) _data164.IsChanged = false;
            if (_data165 != null) _data165.IsChanged = false;
            if (_data166 != null) _data166.IsChanged = false;
            if (_data167 != null) _data167.IsChanged = false;
            if (_data168 != null) _data168.IsChanged = false;
            if (_data169 != null) _data169.IsChanged = false;
            if (_data170 != null) _data170.IsChanged = false;
            if (_data171 != null) _data171.IsChanged = false;
            if (_data172 != null) _data172.IsChanged = false;
            if (_data173 != null) _data173.IsChanged = false;
            if (_data174 != null) _data174.IsChanged = false;
            if (_data175 != null) _data175.IsChanged = false;
            if (_data176 != null) _data176.IsChanged = false;
            if (_data177 != null) _data177.IsChanged = false;
            if (_data178 != null) _data178.IsChanged = false;
            if (_data179 != null) _data179.IsChanged = false;
            if (_data180 != null) _data180.IsChanged = false;
            if (_data181 != null) _data181.IsChanged = false;
            if (_data182 != null) _data182.IsChanged = false;
            if (_data183 != null) _data183.IsChanged = false;
            if (_data184 != null) _data184.IsChanged = false;
            if (_data185 != null) _data185.IsChanged = false;
            if (_data186 != null) _data186.IsChanged = false;
            if (_data187 != null) _data187.IsChanged = false;
            if (_data188 != null) _data188.IsChanged = false;
            if (_data189 != null) _data189.IsChanged = false;
            if (_data190 != null) _data190.IsChanged = false;
            if (_data191 != null) _data191.IsChanged = false;
            if (_data192 != null) _data192.IsChanged = false;
            if (_data193 != null) _data193.IsChanged = false;
            if (_data194 != null) _data194.IsChanged = false;
            if (_data195 != null) _data195.IsChanged = false;
            if (_data196 != null) _data196.IsChanged = false;
            if (_data197 != null) _data197.IsChanged = false;
            if (_data198 != null) _data198.IsChanged = false;
            if (_data199 != null) _data199.IsChanged = false;
            if (_data200 != null) _data200.IsChanged = false;
        }

        #endregion

        #region Member(s)

        private DynamicData _data001 = null;
        private DynamicData _data002 = null;
        private DynamicData _data003 = null;
        private DynamicData _data004 = null;
        private DynamicData _data005 = null;
        private DynamicData _data006 = null;
        private DynamicData _data007 = null;
        private DynamicData _data008 = null;
        private DynamicData _data009 = null;
        private DynamicData _data010 = null;
        private DynamicData _data011 = null;
        private DynamicData _data012 = null;
        private DynamicData _data013 = null;
        private DynamicData _data014 = null;
        private DynamicData _data015 = null;
        private DynamicData _data016 = null;
        private DynamicData _data017 = null;
        private DynamicData _data018 = null;
        private DynamicData _data019 = null;
        private DynamicData _data020 = null;
        private DynamicData _data021 = null;
        private DynamicData _data022 = null;
        private DynamicData _data023 = null;
        private DynamicData _data024 = null;
        private DynamicData _data025 = null;
        private DynamicData _data026 = null;
        private DynamicData _data027 = null;
        private DynamicData _data028 = null;
        private DynamicData _data029 = null;
        private DynamicData _data030 = null;
        private DynamicData _data031 = null;
        private DynamicData _data032 = null;
        private DynamicData _data033 = null;
        private DynamicData _data034 = null;
        private DynamicData _data035 = null;
        private DynamicData _data036 = null;
        private DynamicData _data037 = null;
        private DynamicData _data038 = null;
        private DynamicData _data039 = null;
        private DynamicData _data040 = null;
        private DynamicData _data041 = null;
        private DynamicData _data042 = null;
        private DynamicData _data043 = null;
        private DynamicData _data044 = null;
        private DynamicData _data045 = null;
        private DynamicData _data046 = null;
        private DynamicData _data047 = null;
        private DynamicData _data048 = null;
        private DynamicData _data049 = null;
        private DynamicData _data050 = null;
        private DynamicData _data051 = null;
        private DynamicData _data052 = null;
        private DynamicData _data053 = null;
        private DynamicData _data054 = null;
        private DynamicData _data055 = null;
        private DynamicData _data056 = null;
        private DynamicData _data057 = null;
        private DynamicData _data058 = null;
        private DynamicData _data059 = null;
        private DynamicData _data060 = null;
        private DynamicData _data061 = null;
        private DynamicData _data062 = null;
        private DynamicData _data063 = null;
        private DynamicData _data064 = null;
        private DynamicData _data065 = null;
        private DynamicData _data066 = null;
        private DynamicData _data067 = null;
        private DynamicData _data068 = null;
        private DynamicData _data069 = null;
        private DynamicData _data070 = null;
        private DynamicData _data071 = null;
        private DynamicData _data072 = null;
        private DynamicData _data073 = null;
        private DynamicData _data074 = null;
        private DynamicData _data075 = null;
        private DynamicData _data076 = null;
        private DynamicData _data077 = null;
        private DynamicData _data078 = null;
        private DynamicData _data079 = null;
        private DynamicData _data080 = null;
        private DynamicData _data081 = null;
        private DynamicData _data082 = null;
        private DynamicData _data083 = null;
        private DynamicData _data084 = null;
        private DynamicData _data085 = null;
        private DynamicData _data086 = null;
        private DynamicData _data087 = null;
        private DynamicData _data088 = null;
        private DynamicData _data089 = null;
        private DynamicData _data090 = null;
        private DynamicData _data091 = null;
        private DynamicData _data092 = null;
        private DynamicData _data093 = null;
        private DynamicData _data094 = null;
        private DynamicData _data095 = null;
        private DynamicData _data096 = null;
        private DynamicData _data097 = null;
        private DynamicData _data098 = null;
        private DynamicData _data099 = null;
        private DynamicData _data100 = null;
        private DynamicData _data101 = null;
        private DynamicData _data102 = null;
        private DynamicData _data103 = null;
        private DynamicData _data104 = null;
        private DynamicData _data105 = null;
        private DynamicData _data106 = null;
        private DynamicData _data107 = null;
        private DynamicData _data108 = null;
        private DynamicData _data109 = null;
        private DynamicData _data110 = null;
        private DynamicData _data111 = null;
        private DynamicData _data112 = null;
        private DynamicData _data113 = null;
        private DynamicData _data114 = null;
        private DynamicData _data115 = null;
        private DynamicData _data116 = null;
        private DynamicData _data117 = null;
        private DynamicData _data118 = null;
        private DynamicData _data119 = null;
        private DynamicData _data120 = null;
        private DynamicData _data121 = null;
        private DynamicData _data122 = null;
        private DynamicData _data123 = null;
        private DynamicData _data124 = null;
        private DynamicData _data125 = null;
        private DynamicData _data126 = null;
        private DynamicData _data127 = null;
        private DynamicData _data128 = null;
        private DynamicData _data129 = null;
        private DynamicData _data130 = null;
        private DynamicData _data131 = null;
        private DynamicData _data132 = null;
        private DynamicData _data133 = null;
        private DynamicData _data134 = null;
        private DynamicData _data135 = null;
        private DynamicData _data136 = null;
        private DynamicData _data137 = null;
        private DynamicData _data138 = null;
        private DynamicData _data139 = null;
        private DynamicData _data140 = null;
        private DynamicData _data141 = null;
        private DynamicData _data142 = null;
        private DynamicData _data143 = null;
        private DynamicData _data144 = null;
        private DynamicData _data145 = null;
        private DynamicData _data146 = null;
        private DynamicData _data147 = null;
        private DynamicData _data148 = null;
        private DynamicData _data149 = null;
        private DynamicData _data150 = null;
        private DynamicData _data151 = null;
        private DynamicData _data152 = null;
        private DynamicData _data153 = null;
        private DynamicData _data154 = null;
        private DynamicData _data155 = null;
        private DynamicData _data156 = null;
        private DynamicData _data157 = null;
        private DynamicData _data158 = null;
        private DynamicData _data159 = null;
        private DynamicData _data160 = null;
        private DynamicData _data161 = null;
        private DynamicData _data162 = null;
        private DynamicData _data163 = null;
        private DynamicData _data164 = null;
        private DynamicData _data165 = null;
        private DynamicData _data166 = null;
        private DynamicData _data167 = null;
        private DynamicData _data168 = null;
        private DynamicData _data169 = null;
        private DynamicData _data170 = null;
        private DynamicData _data171 = null;
        private DynamicData _data172 = null;
        private DynamicData _data173 = null;
        private DynamicData _data174 = null;
        private DynamicData _data175 = null;
        private DynamicData _data176 = null;
        private DynamicData _data177 = null;
        private DynamicData _data178 = null;
        private DynamicData _data179 = null;
        private DynamicData _data180 = null;
        private DynamicData _data181 = null;
        private DynamicData _data182 = null;
        private DynamicData _data183 = null;
        private DynamicData _data184 = null;
        private DynamicData _data185 = null;
        private DynamicData _data186 = null;
        private DynamicData _data187 = null;
        private DynamicData _data188 = null;
        private DynamicData _data189 = null;
        private DynamicData _data190 = null;
        private DynamicData _data191 = null;
        private DynamicData _data192 = null;
        private DynamicData _data193 = null;
        private DynamicData _data194 = null;
        private DynamicData _data195 = null;
        private DynamicData _data196 = null;
        private DynamicData _data197 = null;
        private DynamicData _data198 = null;
        private DynamicData _data199 = null;
        private DynamicData _data200 = null;

        #endregion

        #region Properties

        #region Dynamic Datas

        [XmlIgnore]
        public DynamicData Data001 { set { _data001 = value; } }
        [XmlIgnore]
        public DynamicData Data002 { set { _data002 = value; } }
        [XmlIgnore]
        public DynamicData Data003 { set { _data003 = value; } }
        [XmlIgnore]
        public DynamicData Data004 { set { _data004 = value; } }
        [XmlIgnore]
        public DynamicData Data005 { set { _data005 = value; } }
        [XmlIgnore]
        public DynamicData Data006 { set { _data006 = value; } }
        [XmlIgnore]
        public DynamicData Data007 { set { _data007 = value; } }
        [XmlIgnore]
        public DynamicData Data008 { set { _data008 = value; } }
        [XmlIgnore]
        public DynamicData Data009 { set { _data009 = value; } }
        [XmlIgnore]
        public DynamicData Data010 { set { _data010 = value; } }
        [XmlIgnore]
        public DynamicData Data011 { set { _data011 = value; } }
        [XmlIgnore]
        public DynamicData Data012 { set { _data012 = value; } }
        [XmlIgnore]
        public DynamicData Data013 { set { _data013 = value; } }
        [XmlIgnore]
        public DynamicData Data014 { set { _data014 = value; } }
        [XmlIgnore]
        public DynamicData Data015 { set { _data015 = value; } }
        [XmlIgnore]
        public DynamicData Data016 { set { _data016 = value; } }
        [XmlIgnore]
        public DynamicData Data017 { set { _data017 = value; } }
        [XmlIgnore]
        public DynamicData Data018 { set { _data018 = value; } }
        [XmlIgnore]
        public DynamicData Data019 { set { _data019 = value; } }
        [XmlIgnore]
        public DynamicData Data020 { set { _data020 = value; } }
        [XmlIgnore]
        public DynamicData Data021 { set { _data021 = value; } }
        [XmlIgnore]
        public DynamicData Data022 { set { _data022 = value; } }
        [XmlIgnore]
        public DynamicData Data023 { set { _data023 = value; } }
        [XmlIgnore]
        public DynamicData Data024 { set { _data024 = value; } }
        [XmlIgnore]
        public DynamicData Data025 { set { _data025 = value; } }
        [XmlIgnore]
        public DynamicData Data026 { set { _data026 = value; } }
        [XmlIgnore]
        public DynamicData Data027 { set { _data027 = value; } }
        [XmlIgnore]
        public DynamicData Data028 { set { _data028 = value; } }
        [XmlIgnore]
        public DynamicData Data029 { set { _data029 = value; } }
        [XmlIgnore]
        public DynamicData Data030 { set { _data030 = value; } }
        [XmlIgnore]
        public DynamicData Data031 { set { _data031 = value; } }
        [XmlIgnore]
        public DynamicData Data032 { set { _data032 = value; } }
        [XmlIgnore]
        public DynamicData Data033 { set { _data033 = value; } }
        [XmlIgnore]
        public DynamicData Data034 { set { _data034 = value; } }
        [XmlIgnore]
        public DynamicData Data035 { set { _data035 = value; } }
        [XmlIgnore]
        public DynamicData Data036 { set { _data036 = value; } }
        [XmlIgnore]
        public DynamicData Data037 { set { _data037 = value; } }
        [XmlIgnore]
        public DynamicData Data038 { set { _data038 = value; } }
        [XmlIgnore]
        public DynamicData Data039 { set { _data039 = value; } }
        [XmlIgnore]
        public DynamicData Data040 { set { _data040 = value; } }
        [XmlIgnore]
        public DynamicData Data041 { set { _data041 = value; } }
        [XmlIgnore]
        public DynamicData Data042 { set { _data042 = value; } }
        [XmlIgnore]
        public DynamicData Data043 { set { _data043 = value; } }
        [XmlIgnore]
        public DynamicData Data044 { set { _data044 = value; } }
        [XmlIgnore]
        public DynamicData Data045 { set { _data045 = value; } }
        [XmlIgnore]
        public DynamicData Data046 { set { _data046 = value; } }
        [XmlIgnore]
        public DynamicData Data047 { set { _data047 = value; } }
        [XmlIgnore]
        public DynamicData Data048 { set { _data048 = value; } }
        [XmlIgnore]
        public DynamicData Data049 { set { _data049 = value; } }
        [XmlIgnore]
        public DynamicData Data050 { set { _data050 = value; } }
        [XmlIgnore]
        public DynamicData Data051 { set { _data051 = value; } }
        [XmlIgnore]
        public DynamicData Data052 { set { _data052 = value; } }
        [XmlIgnore]
        public DynamicData Data053 { set { _data053 = value; } }
        [XmlIgnore]
        public DynamicData Data054 { set { _data054 = value; } }
        [XmlIgnore]
        public DynamicData Data055 { set { _data055 = value; } }
        [XmlIgnore]
        public DynamicData Data056 { set { _data056 = value; } }
        [XmlIgnore]
        public DynamicData Data057 { set { _data057 = value; } }
        [XmlIgnore]
        public DynamicData Data058 { set { _data058 = value; } }
        [XmlIgnore]
        public DynamicData Data059 { set { _data059 = value; } }
        [XmlIgnore]
        public DynamicData Data060 { set { _data060 = value; } }
        [XmlIgnore]
        public DynamicData Data061 { set { _data061 = value; } }
        [XmlIgnore]
        public DynamicData Data062 { set { _data062 = value; } }
        [XmlIgnore]
        public DynamicData Data063 { set { _data063 = value; } }
        [XmlIgnore]
        public DynamicData Data064 { set { _data064 = value; } }
        [XmlIgnore]
        public DynamicData Data065 { set { _data065 = value; } }
        [XmlIgnore]
        public DynamicData Data066 { set { _data066 = value; } }
        [XmlIgnore]
        public DynamicData Data067 { set { _data067 = value; } }
        [XmlIgnore]
        public DynamicData Data068 { set { _data068 = value; } }
        [XmlIgnore]
        public DynamicData Data069 { set { _data069 = value; } }
        [XmlIgnore]
        public DynamicData Data070 { set { _data070 = value; } }
        [XmlIgnore]
        public DynamicData Data071 { set { _data071 = value; } }
        [XmlIgnore]
        public DynamicData Data072 { set { _data072 = value; } }
        [XmlIgnore]
        public DynamicData Data073 { set { _data073 = value; } }
        [XmlIgnore]
        public DynamicData Data074 { set { _data074 = value; } }
        [XmlIgnore]
        public DynamicData Data075 { set { _data075 = value; } }
        [XmlIgnore]
        public DynamicData Data076 { set { _data076 = value; } }
        [XmlIgnore]
        public DynamicData Data077 { set { _data077 = value; } }
        [XmlIgnore]
        public DynamicData Data078 { set { _data078 = value; } }
        [XmlIgnore]
        public DynamicData Data079 { set { _data079 = value; } }
        [XmlIgnore]
        public DynamicData Data080 { set { _data080 = value; } }
        [XmlIgnore]
        public DynamicData Data081 { set { _data081 = value; } }
        [XmlIgnore]
        public DynamicData Data082 { set { _data082 = value; } }
        [XmlIgnore]
        public DynamicData Data083 { set { _data083 = value; } }
        [XmlIgnore]
        public DynamicData Data084 { set { _data084 = value; } }
        [XmlIgnore]
        public DynamicData Data085 { set { _data085 = value; } }
        [XmlIgnore]
        public DynamicData Data086 { set { _data086 = value; } }
        [XmlIgnore]
        public DynamicData Data087 { set { _data087 = value; } }
        [XmlIgnore]
        public DynamicData Data088 { set { _data088 = value; } }
        [XmlIgnore]
        public DynamicData Data089 { set { _data089 = value; } }
        [XmlIgnore]
        public DynamicData Data090 { set { _data090 = value; } }
        [XmlIgnore]
        public DynamicData Data091 { set { _data091 = value; } }
        [XmlIgnore]
        public DynamicData Data092 { set { _data092 = value; } }
        [XmlIgnore]
        public DynamicData Data093 { set { _data093 = value; } }
        [XmlIgnore]
        public DynamicData Data094 { set { _data094 = value; } }
        [XmlIgnore]
        public DynamicData Data095 { set { _data095 = value; } }
        [XmlIgnore]
        public DynamicData Data096 { set { _data096 = value; } }
        [XmlIgnore]
        public DynamicData Data097 { set { _data097 = value; } }
        [XmlIgnore]
        public DynamicData Data098 { set { _data098 = value; } }
        [XmlIgnore]
        public DynamicData Data099 { set { _data099 = value; } }
        [XmlIgnore]
        public DynamicData Data100 { set { _data100 = value; } }
        [XmlIgnore]
        public DynamicData Data101 { set { _data101 = value; } }
        [XmlIgnore]
        public DynamicData Data102 { set { _data102 = value; } }
        [XmlIgnore]
        public DynamicData Data103 { set { _data103 = value; } }
        [XmlIgnore]
        public DynamicData Data104 { set { _data104 = value; } }
        [XmlIgnore]
        public DynamicData Data105 { set { _data105 = value; } }
        [XmlIgnore]
        public DynamicData Data106 { set { _data106 = value; } }
        [XmlIgnore]
        public DynamicData Data107 { set { _data107 = value; } }
        [XmlIgnore]
        public DynamicData Data108 { set { _data108 = value; } }
        [XmlIgnore]
        public DynamicData Data109 { set { _data109 = value; } }
        [XmlIgnore]
        public DynamicData Data110 { set { _data110 = value; } }
        [XmlIgnore]
        public DynamicData Data111 { set { _data111 = value; } }
        [XmlIgnore]
        public DynamicData Data112 { set { _data112 = value; } }
        [XmlIgnore]
        public DynamicData Data113 { set { _data113 = value; } }
        [XmlIgnore]
        public DynamicData Data114 { set { _data114 = value; } }
        [XmlIgnore]
        public DynamicData Data115 { set { _data115 = value; } }
        [XmlIgnore]
        public DynamicData Data116 { set { _data116 = value; } }
        [XmlIgnore]
        public DynamicData Data117 { set { _data117 = value; } }
        [XmlIgnore]
        public DynamicData Data118 { set { _data118 = value; } }
        [XmlIgnore]
        public DynamicData Data119 { set { _data119 = value; } }
        [XmlIgnore]
        public DynamicData Data120 { set { _data120 = value; } }
        [XmlIgnore]
        public DynamicData Data121 { set { _data121 = value; } }
        [XmlIgnore]
        public DynamicData Data122 { set { _data122 = value; } }
        [XmlIgnore]
        public DynamicData Data123 { set { _data123 = value; } }
        [XmlIgnore]
        public DynamicData Data124 { set { _data124 = value; } }
        [XmlIgnore]
        public DynamicData Data125 { set { _data125 = value; } }
        [XmlIgnore]
        public DynamicData Data126 { set { _data126 = value; } }
        [XmlIgnore]
        public DynamicData Data127 { set { _data127 = value; } }
        [XmlIgnore]
        public DynamicData Data128 { set { _data128 = value; } }
        [XmlIgnore]
        public DynamicData Data129 { set { _data129 = value; } }
        [XmlIgnore]
        public DynamicData Data130 { set { _data130 = value; } }
        [XmlIgnore]
        public DynamicData Data131 { set { _data131 = value; } }
        [XmlIgnore]
        public DynamicData Data132 { set { _data132 = value; } }
        [XmlIgnore]
        public DynamicData Data133 { set { _data133 = value; } }
        [XmlIgnore]
        public DynamicData Data134 { set { _data134 = value; } }
        [XmlIgnore]
        public DynamicData Data135 { set { _data135 = value; } }
        [XmlIgnore]
        public DynamicData Data136 { set { _data136 = value; } }
        [XmlIgnore]
        public DynamicData Data137 { set { _data137 = value; } }
        [XmlIgnore]
        public DynamicData Data138 { set { _data138 = value; } }
        [XmlIgnore]
        public DynamicData Data139 { set { _data139 = value; } }
        [XmlIgnore]
        public DynamicData Data140 { set { _data140 = value; } }
        [XmlIgnore]
        public DynamicData Data141 { set { _data141 = value; } }
        [XmlIgnore]
        public DynamicData Data142 { set { _data142 = value; } }
        [XmlIgnore]
        public DynamicData Data143 { set { _data143 = value; } }
        [XmlIgnore]
        public DynamicData Data144 { set { _data144 = value; } }
        [XmlIgnore]
        public DynamicData Data145 { set { _data145 = value; } }
        [XmlIgnore]
        public DynamicData Data146 { set { _data146 = value; } }
        [XmlIgnore]
        public DynamicData Data147 { set { _data147 = value; } }
        [XmlIgnore]
        public DynamicData Data148 { set { _data148 = value; } }
        [XmlIgnore]
        public DynamicData Data149 { set { _data149 = value; } }
        [XmlIgnore]
        public DynamicData Data150 { set { _data150 = value; } }
        [XmlIgnore]
        public DynamicData Data151 { set { _data151 = value; } }
        [XmlIgnore]
        public DynamicData Data152 { set { _data152 = value; } }
        [XmlIgnore]
        public DynamicData Data153 { set { _data153 = value; } }
        [XmlIgnore]
        public DynamicData Data154 { set { _data154 = value; } }
        [XmlIgnore]
        public DynamicData Data155 { set { _data155 = value; } }
        [XmlIgnore]
        public DynamicData Data156 { set { _data156 = value; } }
        [XmlIgnore]
        public DynamicData Data157 { set { _data157 = value; } }
        [XmlIgnore]
        public DynamicData Data158 { set { _data158 = value; } }
        [XmlIgnore]
        public DynamicData Data159 { set { _data159 = value; } }
        [XmlIgnore]
        public DynamicData Data160 { set { _data160 = value; } }
        [XmlIgnore]
        public DynamicData Data161 { set { _data161 = value; } }
        [XmlIgnore]
        public DynamicData Data162 { set { _data162 = value; } }
        [XmlIgnore]
        public DynamicData Data163 { set { _data163 = value; } }
        [XmlIgnore]
        public DynamicData Data164 { set { _data164 = value; } }
        [XmlIgnore]
        public DynamicData Data165 { set { _data165 = value; } }
        [XmlIgnore]
        public DynamicData Data166 { set { _data166 = value; } }
        [XmlIgnore]
        public DynamicData Data167 { set { _data167 = value; } }
        [XmlIgnore]
        public DynamicData Data168 { set { _data168 = value; } }
        [XmlIgnore]
        public DynamicData Data169 { set { _data169 = value; } }
        [XmlIgnore]
        public DynamicData Data170 { set { _data170 = value; } }
        [XmlIgnore]
        public DynamicData Data171 { set { _data171 = value; } }
        [XmlIgnore]
        public DynamicData Data172 { set { _data172 = value; } }
        [XmlIgnore]
        public DynamicData Data173 { set { _data173 = value; } }
        [XmlIgnore]
        public DynamicData Data174 { set { _data174 = value; } }
        [XmlIgnore]
        public DynamicData Data175 { set { _data175 = value; } }
        [XmlIgnore]
        public DynamicData Data176 { set { _data176 = value; } }
        [XmlIgnore]
        public DynamicData Data177 { set { _data177 = value; } }
        [XmlIgnore]
        public DynamicData Data178 { set { _data178 = value; } }
        [XmlIgnore]
        public DynamicData Data179 { set { _data179 = value; } }
        [XmlIgnore]
        public DynamicData Data180 { set { _data180 = value; } }
        [XmlIgnore]
        public DynamicData Data181 { set { _data181 = value; } }
        [XmlIgnore]
        public DynamicData Data182 { set { _data182 = value; } }
        [XmlIgnore]
        public DynamicData Data183 { set { _data183 = value; } }
        [XmlIgnore]
        public DynamicData Data184 { set { _data184 = value; } }
        [XmlIgnore]
        public DynamicData Data185 { set { _data185 = value; } }
        [XmlIgnore]
        public DynamicData Data186 { set { _data186 = value; } }
        [XmlIgnore]
        public DynamicData Data187 { set { _data187 = value; } }
        [XmlIgnore]
        public DynamicData Data188 { set { _data188 = value; } }
        [XmlIgnore]
        public DynamicData Data189 { set { _data189 = value; } }
        [XmlIgnore]
        public DynamicData Data190 { set { _data190 = value; } }
        [XmlIgnore]
        public DynamicData Data191 { set { _data191 = value; } }
        [XmlIgnore]
        public DynamicData Data192 { set { _data192 = value; } }
        [XmlIgnore]
        public DynamicData Data193 { set { _data193 = value; } }
        [XmlIgnore]
        public DynamicData Data194 { set { _data194 = value; } }
        [XmlIgnore]
        public DynamicData Data195 { set { _data195 = value; } }
        [XmlIgnore]
        public DynamicData Data196 { set { _data196 = value; } }
        [XmlIgnore]
        public DynamicData Data197 { set { _data197 = value; } }
        [XmlIgnore]
        public DynamicData Data198 { set { _data198 = value; } }
        [XmlIgnore]
        public DynamicData Data199 { set { _data199 = value; } }
        [XmlIgnore]
        public DynamicData Data200 { set { _data200 = value; } }

        #endregion

        [XmlIgnore]
        public virtual bool IsDeleted
        {
            set
            {
                if (_data001 != null) _data001.IsDeleted = value;
                if (_data002 != null) _data002.IsDeleted = value;
                if (_data003 != null) _data003.IsDeleted = value;
                if (_data004 != null) _data004.IsDeleted = value;
                if (_data005 != null) _data005.IsDeleted = value;
                if (_data006 != null) _data006.IsDeleted = value;
                if (_data007 != null) _data007.IsDeleted = value;
                if (_data008 != null) _data008.IsDeleted = value;
                if (_data009 != null) _data009.IsDeleted = value;
                if (_data010 != null) _data010.IsDeleted = value;
                if (_data011 != null) _data011.IsDeleted = value;
                if (_data012 != null) _data012.IsDeleted = value;
                if (_data013 != null) _data013.IsDeleted = value;
                if (_data014 != null) _data014.IsDeleted = value;
                if (_data015 != null) _data015.IsDeleted = value;
                if (_data016 != null) _data016.IsDeleted = value;
                if (_data017 != null) _data017.IsDeleted = value;
                if (_data018 != null) _data018.IsDeleted = value;
                if (_data019 != null) _data019.IsDeleted = value;
                if (_data020 != null) _data020.IsDeleted = value;
                if (_data021 != null) _data021.IsDeleted = value;
                if (_data022 != null) _data022.IsDeleted = value;
                if (_data023 != null) _data023.IsDeleted = value;
                if (_data024 != null) _data024.IsDeleted = value;
                if (_data025 != null) _data025.IsDeleted = value;
                if (_data026 != null) _data026.IsDeleted = value;
                if (_data027 != null) _data027.IsDeleted = value;
                if (_data028 != null) _data028.IsDeleted = value;
                if (_data029 != null) _data029.IsDeleted = value;
                if (_data030 != null) _data030.IsDeleted = value;
                if (_data031 != null) _data031.IsDeleted = value;
                if (_data032 != null) _data032.IsDeleted = value;
                if (_data033 != null) _data033.IsDeleted = value;
                if (_data034 != null) _data034.IsDeleted = value;
                if (_data035 != null) _data035.IsDeleted = value;
                if (_data036 != null) _data036.IsDeleted = value;
                if (_data037 != null) _data037.IsDeleted = value;
                if (_data038 != null) _data038.IsDeleted = value;
                if (_data039 != null) _data039.IsDeleted = value;
                if (_data040 != null) _data040.IsDeleted = value;
                if (_data041 != null) _data041.IsDeleted = value;
                if (_data042 != null) _data042.IsDeleted = value;
                if (_data043 != null) _data043.IsDeleted = value;
                if (_data044 != null) _data044.IsDeleted = value;
                if (_data045 != null) _data045.IsDeleted = value;
                if (_data046 != null) _data046.IsDeleted = value;
                if (_data047 != null) _data047.IsDeleted = value;
                if (_data048 != null) _data048.IsDeleted = value;
                if (_data049 != null) _data049.IsDeleted = value;
                if (_data050 != null) _data050.IsDeleted = value;
                if (_data051 != null) _data051.IsDeleted = value;
                if (_data052 != null) _data052.IsDeleted = value;
                if (_data053 != null) _data053.IsDeleted = value;
                if (_data054 != null) _data054.IsDeleted = value;
                if (_data055 != null) _data055.IsDeleted = value;
                if (_data056 != null) _data056.IsDeleted = value;
                if (_data057 != null) _data057.IsDeleted = value;
                if (_data058 != null) _data058.IsDeleted = value;
                if (_data059 != null) _data059.IsDeleted = value;
                if (_data060 != null) _data060.IsDeleted = value;
                if (_data061 != null) _data061.IsDeleted = value;
                if (_data062 != null) _data062.IsDeleted = value;
                if (_data063 != null) _data063.IsDeleted = value;
                if (_data064 != null) _data064.IsDeleted = value;
                if (_data065 != null) _data065.IsDeleted = value;
                if (_data066 != null) _data066.IsDeleted = value;
                if (_data067 != null) _data067.IsDeleted = value;
                if (_data068 != null) _data068.IsDeleted = value;
                if (_data069 != null) _data069.IsDeleted = value;
                if (_data070 != null) _data070.IsDeleted = value;
                if (_data071 != null) _data071.IsDeleted = value;
                if (_data072 != null) _data072.IsDeleted = value;
                if (_data073 != null) _data073.IsDeleted = value;
                if (_data074 != null) _data074.IsDeleted = value;
                if (_data075 != null) _data075.IsDeleted = value;
                if (_data076 != null) _data076.IsDeleted = value;
                if (_data077 != null) _data077.IsDeleted = value;
                if (_data078 != null) _data078.IsDeleted = value;
                if (_data079 != null) _data079.IsDeleted = value;
                if (_data080 != null) _data080.IsDeleted = value;
                if (_data081 != null) _data081.IsDeleted = value;
                if (_data082 != null) _data082.IsDeleted = value;
                if (_data083 != null) _data083.IsDeleted = value;
                if (_data084 != null) _data084.IsDeleted = value;
                if (_data085 != null) _data085.IsDeleted = value;
                if (_data086 != null) _data086.IsDeleted = value;
                if (_data087 != null) _data087.IsDeleted = value;
                if (_data088 != null) _data088.IsDeleted = value;
                if (_data089 != null) _data089.IsDeleted = value;
                if (_data090 != null) _data090.IsDeleted = value;
                if (_data091 != null) _data091.IsDeleted = value;
                if (_data092 != null) _data092.IsDeleted = value;
                if (_data093 != null) _data093.IsDeleted = value;
                if (_data094 != null) _data094.IsDeleted = value;
                if (_data095 != null) _data095.IsDeleted = value;
                if (_data096 != null) _data096.IsDeleted = value;
                if (_data097 != null) _data097.IsDeleted = value;
                if (_data098 != null) _data098.IsDeleted = value;
                if (_data099 != null) _data099.IsDeleted = value;
                if (_data100 != null) _data100.IsDeleted = value;
                if (_data101 != null) _data101.IsDeleted = value;
                if (_data102 != null) _data102.IsDeleted = value;
                if (_data103 != null) _data103.IsDeleted = value;
                if (_data104 != null) _data104.IsDeleted = value;
                if (_data105 != null) _data105.IsDeleted = value;
                if (_data106 != null) _data106.IsDeleted = value;
                if (_data107 != null) _data107.IsDeleted = value;
                if (_data108 != null) _data108.IsDeleted = value;
                if (_data109 != null) _data109.IsDeleted = value;
                if (_data110 != null) _data110.IsDeleted = value;
                if (_data111 != null) _data111.IsDeleted = value;
                if (_data112 != null) _data112.IsDeleted = value;
                if (_data113 != null) _data113.IsDeleted = value;
                if (_data114 != null) _data114.IsDeleted = value;
                if (_data115 != null) _data115.IsDeleted = value;
                if (_data116 != null) _data116.IsDeleted = value;
                if (_data117 != null) _data117.IsDeleted = value;
                if (_data118 != null) _data118.IsDeleted = value;
                if (_data119 != null) _data119.IsDeleted = value;
                if (_data120 != null) _data120.IsDeleted = value;
                if (_data121 != null) _data121.IsDeleted = value;
                if (_data122 != null) _data122.IsDeleted = value;
                if (_data123 != null) _data123.IsDeleted = value;
                if (_data124 != null) _data124.IsDeleted = value;
                if (_data125 != null) _data125.IsDeleted = value;
                if (_data126 != null) _data126.IsDeleted = value;
                if (_data127 != null) _data127.IsDeleted = value;
                if (_data128 != null) _data128.IsDeleted = value;
                if (_data129 != null) _data129.IsDeleted = value;
                if (_data130 != null) _data130.IsDeleted = value;
                if (_data131 != null) _data131.IsDeleted = value;
                if (_data132 != null) _data132.IsDeleted = value;
                if (_data133 != null) _data133.IsDeleted = value;
                if (_data134 != null) _data134.IsDeleted = value;
                if (_data135 != null) _data135.IsDeleted = value;
                if (_data136 != null) _data136.IsDeleted = value;
                if (_data137 != null) _data137.IsDeleted = value;
                if (_data138 != null) _data138.IsDeleted = value;
                if (_data139 != null) _data139.IsDeleted = value;
                if (_data140 != null) _data140.IsDeleted = value;
                if (_data141 != null) _data141.IsDeleted = value;
                if (_data142 != null) _data142.IsDeleted = value;
                if (_data143 != null) _data143.IsDeleted = value;
                if (_data144 != null) _data144.IsDeleted = value;
                if (_data145 != null) _data145.IsDeleted = value;
                if (_data146 != null) _data146.IsDeleted = value;
                if (_data147 != null) _data147.IsDeleted = value;
                if (_data148 != null) _data148.IsDeleted = value;
                if (_data149 != null) _data149.IsDeleted = value;
                if (_data150 != null) _data150.IsDeleted = value;
                if (_data151 != null) _data151.IsDeleted = value;
                if (_data152 != null) _data152.IsDeleted = value;
                if (_data153 != null) _data153.IsDeleted = value;
                if (_data154 != null) _data154.IsDeleted = value;
                if (_data155 != null) _data155.IsDeleted = value;
                if (_data156 != null) _data156.IsDeleted = value;
                if (_data157 != null) _data157.IsDeleted = value;
                if (_data158 != null) _data158.IsDeleted = value;
                if (_data159 != null) _data159.IsDeleted = value;
                if (_data160 != null) _data160.IsDeleted = value;
                if (_data161 != null) _data161.IsDeleted = value;
                if (_data162 != null) _data162.IsDeleted = value;
                if (_data163 != null) _data163.IsDeleted = value;
                if (_data164 != null) _data164.IsDeleted = value;
                if (_data165 != null) _data165.IsDeleted = value;
                if (_data166 != null) _data166.IsDeleted = value;
                if (_data167 != null) _data167.IsDeleted = value;
                if (_data168 != null) _data168.IsDeleted = value;
                if (_data169 != null) _data169.IsDeleted = value;
                if (_data170 != null) _data170.IsDeleted = value;
                if (_data171 != null) _data171.IsDeleted = value;
                if (_data172 != null) _data172.IsDeleted = value;
                if (_data173 != null) _data173.IsDeleted = value;
                if (_data174 != null) _data174.IsDeleted = value;
                if (_data175 != null) _data175.IsDeleted = value;
                if (_data176 != null) _data176.IsDeleted = value;
                if (_data177 != null) _data177.IsDeleted = value;
                if (_data178 != null) _data178.IsDeleted = value;
                if (_data179 != null) _data179.IsDeleted = value;
                if (_data180 != null) _data180.IsDeleted = value;
                if (_data181 != null) _data181.IsDeleted = value;
                if (_data182 != null) _data182.IsDeleted = value;
                if (_data183 != null) _data183.IsDeleted = value;
                if (_data184 != null) _data184.IsDeleted = value;
                if (_data185 != null) _data185.IsDeleted = value;
                if (_data186 != null) _data186.IsDeleted = value;
                if (_data187 != null) _data187.IsDeleted = value;
                if (_data188 != null) _data188.IsDeleted = value;
                if (_data189 != null) _data189.IsDeleted = value;
                if (_data190 != null) _data190.IsDeleted = value;
                if (_data191 != null) _data191.IsDeleted = value;
                if (_data192 != null) _data192.IsDeleted = value;
                if (_data193 != null) _data193.IsDeleted = value;
                if (_data194 != null) _data194.IsDeleted = value;
                if (_data195 != null) _data195.IsDeleted = value;
                if (_data196 != null) _data196.IsDeleted = value;
                if (_data197 != null) _data197.IsDeleted = value;
                if (_data198 != null) _data198.IsDeleted = value;
                if (_data199 != null) _data199.IsDeleted = value;
                if (_data200 != null) _data200.IsDeleted = value;
            }
        }

        #region Dynamic Cells

        [XmlIgnore]
        public object Cell001 { get { if (_data001 != null) return _data001.Value; return null; } set { if (_data001 != null) 	_data001.Value = value; } }
        [XmlIgnore]
        public object Cell002 { get { if (_data002 != null) return _data002.Value; return null; } set { if (_data002 != null) 	_data002.Value = value; } }
        [XmlIgnore]
        public object Cell003 { get { if (_data003 != null) return _data003.Value; return null; } set { if (_data003 != null) 	_data003.Value = value; } }
        [XmlIgnore]
        public object Cell004 { get { if (_data004 != null) return _data004.Value; return null; } set { if (_data004 != null) 	_data004.Value = value; } }
        [XmlIgnore]
        public object Cell005 { get { if (_data005 != null) return _data005.Value; return null; } set { if (_data005 != null) 	_data005.Value = value; } }
        [XmlIgnore]
        public object Cell006 { get { if (_data006 != null) return _data006.Value; return null; } set { if (_data006 != null) 	_data006.Value = value; } }
        [XmlIgnore]
        public object Cell007 { get { if (_data007 != null) return _data007.Value; return null; } set { if (_data007 != null) 	_data007.Value = value; } }
        [XmlIgnore]
        public object Cell008 { get { if (_data008 != null) return _data008.Value; return null; } set { if (_data008 != null) 	_data008.Value = value; } }
        [XmlIgnore]
        public object Cell009 { get { if (_data009 != null) return _data009.Value; return null; } set { if (_data009 != null) 	_data009.Value = value; } }
        [XmlIgnore]
        public object Cell010 { get { if (_data010 != null) return _data010.Value; return null; } set { if (_data010 != null) 	_data010.Value = value; } }
        [XmlIgnore]
        public object Cell011 { get { if (_data011 != null) return _data011.Value; return null; } set { if (_data011 != null) 	_data011.Value = value; } }
        [XmlIgnore]
        public object Cell012 { get { if (_data012 != null) return _data012.Value; return null; } set { if (_data012 != null) 	_data012.Value = value; } }
        [XmlIgnore]
        public object Cell013 { get { if (_data013 != null) return _data013.Value; return null; } set { if (_data013 != null) 	_data013.Value = value; } }
        [XmlIgnore]
        public object Cell014 { get { if (_data014 != null) return _data014.Value; return null; } set { if (_data014 != null) 	_data014.Value = value; } }
        [XmlIgnore]
        public object Cell015 { get { if (_data015 != null) return _data015.Value; return null; } set { if (_data015 != null) 	_data015.Value = value; } }
        [XmlIgnore]
        public object Cell016 { get { if (_data016 != null) return _data016.Value; return null; } set { if (_data016 != null) 	_data016.Value = value; } }
        [XmlIgnore]
        public object Cell017 { get { if (_data017 != null) return _data017.Value; return null; } set { if (_data017 != null) 	_data017.Value = value; } }
        [XmlIgnore]
        public object Cell018 { get { if (_data018 != null) return _data018.Value; return null; } set { if (_data018 != null) 	_data018.Value = value; } }
        [XmlIgnore]
        public object Cell019 { get { if (_data019 != null) return _data019.Value; return null; } set { if (_data019 != null) 	_data019.Value = value; } }
        [XmlIgnore]
        public object Cell020 { get { if (_data020 != null) return _data020.Value; return null; } set { if (_data020 != null) 	_data020.Value = value; } }
        [XmlIgnore]
        public object Cell021 { get { if (_data021 != null) return _data021.Value; return null; } set { if (_data021 != null) 	_data021.Value = value; } }
        [XmlIgnore]
        public object Cell022 { get { if (_data022 != null) return _data022.Value; return null; } set { if (_data022 != null) 	_data022.Value = value; } }
        [XmlIgnore]
        public object Cell023 { get { if (_data023 != null) return _data023.Value; return null; } set { if (_data023 != null) 	_data023.Value = value; } }
        [XmlIgnore]
        public object Cell024 { get { if (_data024 != null) return _data024.Value; return null; } set { if (_data024 != null) 	_data024.Value = value; } }
        [XmlIgnore]
        public object Cell025 { get { if (_data025 != null) return _data025.Value; return null; } set { if (_data025 != null) 	_data025.Value = value; } }
        [XmlIgnore]
        public object Cell026 { get { if (_data026 != null) return _data026.Value; return null; } set { if (_data026 != null) 	_data026.Value = value; } }
        [XmlIgnore]
        public object Cell027 { get { if (_data027 != null) return _data027.Value; return null; } set { if (_data027 != null) 	_data027.Value = value; } }
        [XmlIgnore]
        public object Cell028 { get { if (_data028 != null) return _data028.Value; return null; } set { if (_data028 != null) 	_data028.Value = value; } }
        [XmlIgnore]
        public object Cell029 { get { if (_data029 != null) return _data029.Value; return null; } set { if (_data029 != null) 	_data029.Value = value; } }
        [XmlIgnore]
        public object Cell030 { get { if (_data030 != null) return _data030.Value; return null; } set { if (_data030 != null) 	_data030.Value = value; } }
        [XmlIgnore]
        public object Cell031 { get { if (_data031 != null) return _data031.Value; return null; } set { if (_data031 != null) 	_data031.Value = value; } }
        [XmlIgnore]
        public object Cell032 { get { if (_data032 != null) return _data032.Value; return null; } set { if (_data032 != null) 	_data032.Value = value; } }
        [XmlIgnore]
        public object Cell033 { get { if (_data033 != null) return _data033.Value; return null; } set { if (_data033 != null) 	_data033.Value = value; } }
        [XmlIgnore]
        public object Cell034 { get { if (_data034 != null) return _data034.Value; return null; } set { if (_data034 != null) 	_data034.Value = value; } }
        [XmlIgnore]
        public object Cell035 { get { if (_data035 != null) return _data035.Value; return null; } set { if (_data035 != null) 	_data035.Value = value; } }
        [XmlIgnore]
        public object Cell036 { get { if (_data036 != null) return _data036.Value; return null; } set { if (_data036 != null) 	_data036.Value = value; } }
        [XmlIgnore]
        public object Cell037 { get { if (_data037 != null) return _data037.Value; return null; } set { if (_data037 != null) 	_data037.Value = value; } }
        [XmlIgnore]
        public object Cell038 { get { if (_data038 != null) return _data038.Value; return null; } set { if (_data038 != null) 	_data038.Value = value; } }
        [XmlIgnore]
        public object Cell039 { get { if (_data039 != null) return _data039.Value; return null; } set { if (_data039 != null) 	_data039.Value = value; } }
        [XmlIgnore]
        public object Cell040 { get { if (_data040 != null) return _data040.Value; return null; } set { if (_data040 != null) 	_data040.Value = value; } }
        [XmlIgnore]
        public object Cell041 { get { if (_data041 != null) return _data041.Value; return null; } set { if (_data041 != null) 	_data041.Value = value; } }
        [XmlIgnore]
        public object Cell042 { get { if (_data042 != null) return _data042.Value; return null; } set { if (_data042 != null) 	_data042.Value = value; } }
        [XmlIgnore]
        public object Cell043 { get { if (_data043 != null) return _data043.Value; return null; } set { if (_data043 != null) 	_data043.Value = value; } }
        [XmlIgnore]
        public object Cell044 { get { if (_data044 != null) return _data044.Value; return null; } set { if (_data044 != null) 	_data044.Value = value; } }
        [XmlIgnore]
        public object Cell045 { get { if (_data045 != null) return _data045.Value; return null; } set { if (_data045 != null) 	_data045.Value = value; } }
        [XmlIgnore]
        public object Cell046 { get { if (_data046 != null) return _data046.Value; return null; } set { if (_data046 != null) 	_data046.Value = value; } }
        [XmlIgnore]
        public object Cell047 { get { if (_data047 != null) return _data047.Value; return null; } set { if (_data047 != null) 	_data047.Value = value; } }
        [XmlIgnore]
        public object Cell048 { get { if (_data048 != null) return _data048.Value; return null; } set { if (_data048 != null) 	_data048.Value = value; } }
        [XmlIgnore]
        public object Cell049 { get { if (_data049 != null) return _data049.Value; return null; } set { if (_data049 != null) 	_data049.Value = value; } }
        [XmlIgnore]
        public object Cell050 { get { if (_data050 != null) return _data050.Value; return null; } set { if (_data050 != null) 	_data050.Value = value; } }
        [XmlIgnore]
        public object Cell051 { get { if (_data051 != null) return _data051.Value; return null; } set { if (_data051 != null) 	_data051.Value = value; } }
        [XmlIgnore]
        public object Cell052 { get { if (_data052 != null) return _data052.Value; return null; } set { if (_data052 != null) 	_data052.Value = value; } }
        [XmlIgnore]
        public object Cell053 { get { if (_data053 != null) return _data053.Value; return null; } set { if (_data053 != null) 	_data053.Value = value; } }
        [XmlIgnore]
        public object Cell054 { get { if (_data054 != null) return _data054.Value; return null; } set { if (_data054 != null) 	_data054.Value = value; } }
        [XmlIgnore]
        public object Cell055 { get { if (_data055 != null) return _data055.Value; return null; } set { if (_data055 != null) 	_data055.Value = value; } }
        [XmlIgnore]
        public object Cell056 { get { if (_data056 != null) return _data056.Value; return null; } set { if (_data056 != null) 	_data056.Value = value; } }
        [XmlIgnore]
        public object Cell057 { get { if (_data057 != null) return _data057.Value; return null; } set { if (_data057 != null) 	_data057.Value = value; } }
        [XmlIgnore]
        public object Cell058 { get { if (_data058 != null) return _data058.Value; return null; } set { if (_data058 != null) 	_data058.Value = value; } }
        [XmlIgnore]
        public object Cell059 { get { if (_data059 != null) return _data059.Value; return null; } set { if (_data059 != null) 	_data059.Value = value; } }
        [XmlIgnore]
        public object Cell060 { get { if (_data060 != null) return _data060.Value; return null; } set { if (_data060 != null) 	_data060.Value = value; } }
        [XmlIgnore]
        public object Cell061 { get { if (_data061 != null) return _data061.Value; return null; } set { if (_data061 != null) 	_data061.Value = value; } }
        [XmlIgnore]
        public object Cell062 { get { if (_data062 != null) return _data062.Value; return null; } set { if (_data062 != null) 	_data062.Value = value; } }
        [XmlIgnore]
        public object Cell063 { get { if (_data063 != null) return _data063.Value; return null; } set { if (_data063 != null) 	_data063.Value = value; } }
        [XmlIgnore]
        public object Cell064 { get { if (_data064 != null) return _data064.Value; return null; } set { if (_data064 != null) 	_data064.Value = value; } }
        [XmlIgnore]
        public object Cell065 { get { if (_data065 != null) return _data065.Value; return null; } set { if (_data065 != null) 	_data065.Value = value; } }
        [XmlIgnore]
        public object Cell066 { get { if (_data066 != null) return _data066.Value; return null; } set { if (_data066 != null) 	_data066.Value = value; } }
        [XmlIgnore]
        public object Cell067 { get { if (_data067 != null) return _data067.Value; return null; } set { if (_data067 != null) 	_data067.Value = value; } }
        [XmlIgnore]
        public object Cell068 { get { if (_data068 != null) return _data068.Value; return null; } set { if (_data068 != null) 	_data068.Value = value; } }
        [XmlIgnore]
        public object Cell069 { get { if (_data069 != null) return _data069.Value; return null; } set { if (_data069 != null) 	_data069.Value = value; } }
        [XmlIgnore]
        public object Cell070 { get { if (_data070 != null) return _data070.Value; return null; } set { if (_data070 != null) 	_data070.Value = value; } }
        [XmlIgnore]
        public object Cell071 { get { if (_data071 != null) return _data071.Value; return null; } set { if (_data071 != null) 	_data071.Value = value; } }
        [XmlIgnore]
        public object Cell072 { get { if (_data072 != null) return _data072.Value; return null; } set { if (_data072 != null) 	_data072.Value = value; } }
        [XmlIgnore]
        public object Cell073 { get { if (_data073 != null) return _data073.Value; return null; } set { if (_data073 != null) 	_data073.Value = value; } }
        [XmlIgnore]
        public object Cell074 { get { if (_data074 != null) return _data074.Value; return null; } set { if (_data074 != null) 	_data074.Value = value; } }
        [XmlIgnore]
        public object Cell075 { get { if (_data075 != null) return _data075.Value; return null; } set { if (_data075 != null) 	_data075.Value = value; } }
        [XmlIgnore]
        public object Cell076 { get { if (_data076 != null) return _data076.Value; return null; } set { if (_data076 != null) 	_data076.Value = value; } }
        [XmlIgnore]
        public object Cell077 { get { if (_data077 != null) return _data077.Value; return null; } set { if (_data077 != null) 	_data077.Value = value; } }
        [XmlIgnore]
        public object Cell078 { get { if (_data078 != null) return _data078.Value; return null; } set { if (_data078 != null) 	_data078.Value = value; } }
        [XmlIgnore]
        public object Cell079 { get { if (_data079 != null) return _data079.Value; return null; } set { if (_data079 != null) 	_data079.Value = value; } }
        [XmlIgnore]
        public object Cell080 { get { if (_data080 != null) return _data080.Value; return null; } set { if (_data080 != null) 	_data080.Value = value; } }
        [XmlIgnore]
        public object Cell081 { get { if (_data081 != null) return _data081.Value; return null; } set { if (_data081 != null) 	_data081.Value = value; } }
        [XmlIgnore]
        public object Cell082 { get { if (_data082 != null) return _data082.Value; return null; } set { if (_data082 != null) 	_data082.Value = value; } }
        [XmlIgnore]
        public object Cell083 { get { if (_data083 != null) return _data083.Value; return null; } set { if (_data083 != null) 	_data083.Value = value; } }
        [XmlIgnore]
        public object Cell084 { get { if (_data084 != null) return _data084.Value; return null; } set { if (_data084 != null) 	_data084.Value = value; } }
        [XmlIgnore]
        public object Cell085 { get { if (_data085 != null) return _data085.Value; return null; } set { if (_data085 != null) 	_data085.Value = value; } }
        [XmlIgnore]
        public object Cell086 { get { if (_data086 != null) return _data086.Value; return null; } set { if (_data086 != null) 	_data086.Value = value; } }
        [XmlIgnore]
        public object Cell087 { get { if (_data087 != null) return _data087.Value; return null; } set { if (_data087 != null) 	_data087.Value = value; } }
        [XmlIgnore]
        public object Cell088 { get { if (_data088 != null) return _data088.Value; return null; } set { if (_data088 != null) 	_data088.Value = value; } }
        [XmlIgnore]
        public object Cell089 { get { if (_data089 != null) return _data089.Value; return null; } set { if (_data089 != null) 	_data089.Value = value; } }
        [XmlIgnore]
        public object Cell090 { get { if (_data090 != null) return _data090.Value; return null; } set { if (_data090 != null) 	_data090.Value = value; } }
        [XmlIgnore]
        public object Cell091 { get { if (_data091 != null) return _data091.Value; return null; } set { if (_data091 != null) 	_data091.Value = value; } }
        [XmlIgnore]
        public object Cell092 { get { if (_data092 != null) return _data092.Value; return null; } set { if (_data092 != null) 	_data092.Value = value; } }
        [XmlIgnore]
        public object Cell093 { get { if (_data093 != null) return _data093.Value; return null; } set { if (_data093 != null) 	_data093.Value = value; } }
        [XmlIgnore]
        public object Cell094 { get { if (_data094 != null) return _data094.Value; return null; } set { if (_data094 != null) 	_data094.Value = value; } }
        [XmlIgnore]
        public object Cell095 { get { if (_data095 != null) return _data095.Value; return null; } set { if (_data095 != null) 	_data095.Value = value; } }
        [XmlIgnore]
        public object Cell096 { get { if (_data096 != null) return _data096.Value; return null; } set { if (_data096 != null) 	_data096.Value = value; } }
        [XmlIgnore]
        public object Cell097 { get { if (_data097 != null) return _data097.Value; return null; } set { if (_data097 != null) 	_data097.Value = value; } }
        [XmlIgnore]
        public object Cell098 { get { if (_data098 != null) return _data098.Value; return null; } set { if (_data098 != null) 	_data098.Value = value; } }
        [XmlIgnore]
        public object Cell099 { get { if (_data099 != null) return _data099.Value; return null; } set { if (_data099 != null) 	_data099.Value = value; } }
        [XmlIgnore]
        public object Cell100 { get { if (_data100 != null) return _data100.Value; return null; } set { if (_data100 != null) 	_data100.Value = value; } }
        [XmlIgnore]
        public object Cell101 { get { if (_data101 != null) return _data101.Value; return null; } set { if (_data101 != null) 	_data101.Value = value; } }
        [XmlIgnore]
        public object Cell102 { get { if (_data102 != null) return _data102.Value; return null; } set { if (_data102 != null) 	_data102.Value = value; } }
        [XmlIgnore]
        public object Cell103 { get { if (_data103 != null) return _data103.Value; return null; } set { if (_data103 != null) 	_data103.Value = value; } }
        [XmlIgnore]
        public object Cell104 { get { if (_data104 != null) return _data104.Value; return null; } set { if (_data104 != null) 	_data104.Value = value; } }
        [XmlIgnore]
        public object Cell105 { get { if (_data105 != null) return _data105.Value; return null; } set { if (_data105 != null) 	_data105.Value = value; } }
        [XmlIgnore]
        public object Cell106 { get { if (_data106 != null) return _data106.Value; return null; } set { if (_data106 != null) 	_data106.Value = value; } }
        [XmlIgnore]
        public object Cell107 { get { if (_data107 != null) return _data107.Value; return null; } set { if (_data107 != null) 	_data107.Value = value; } }
        [XmlIgnore]
        public object Cell108 { get { if (_data108 != null) return _data108.Value; return null; } set { if (_data108 != null) 	_data108.Value = value; } }
        [XmlIgnore]
        public object Cell109 { get { if (_data109 != null) return _data109.Value; return null; } set { if (_data109 != null) 	_data109.Value = value; } }
        [XmlIgnore]
        public object Cell110 { get { if (_data110 != null) return _data110.Value; return null; } set { if (_data110 != null) 	_data110.Value = value; } }
        [XmlIgnore]
        public object Cell111 { get { if (_data111 != null) return _data111.Value; return null; } set { if (_data111 != null) 	_data111.Value = value; } }
        [XmlIgnore]
        public object Cell112 { get { if (_data112 != null) return _data112.Value; return null; } set { if (_data112 != null) 	_data112.Value = value; } }
        [XmlIgnore]
        public object Cell113 { get { if (_data113 != null) return _data113.Value; return null; } set { if (_data113 != null) 	_data113.Value = value; } }
        [XmlIgnore]
        public object Cell114 { get { if (_data114 != null) return _data114.Value; return null; } set { if (_data114 != null) 	_data114.Value = value; } }
        [XmlIgnore]
        public object Cell115 { get { if (_data115 != null) return _data115.Value; return null; } set { if (_data115 != null) 	_data115.Value = value; } }
        [XmlIgnore]
        public object Cell116 { get { if (_data116 != null) return _data116.Value; return null; } set { if (_data116 != null) 	_data116.Value = value; } }
        [XmlIgnore]
        public object Cell117 { get { if (_data117 != null) return _data117.Value; return null; } set { if (_data117 != null) 	_data117.Value = value; } }
        [XmlIgnore]
        public object Cell118 { get { if (_data118 != null) return _data118.Value; return null; } set { if (_data118 != null) 	_data118.Value = value; } }
        [XmlIgnore]
        public object Cell119 { get { if (_data119 != null) return _data119.Value; return null; } set { if (_data119 != null) 	_data119.Value = value; } }
        [XmlIgnore]
        public object Cell120 { get { if (_data120 != null) return _data120.Value; return null; } set { if (_data120 != null) 	_data120.Value = value; } }
        [XmlIgnore]
        public object Cell121 { get { if (_data121 != null) return _data121.Value; return null; } set { if (_data121 != null) 	_data121.Value = value; } }
        [XmlIgnore]
        public object Cell122 { get { if (_data122 != null) return _data122.Value; return null; } set { if (_data122 != null) 	_data122.Value = value; } }
        [XmlIgnore]
        public object Cell123 { get { if (_data123 != null) return _data123.Value; return null; } set { if (_data123 != null) 	_data123.Value = value; } }
        [XmlIgnore]
        public object Cell124 { get { if (_data124 != null) return _data124.Value; return null; } set { if (_data124 != null) 	_data124.Value = value; } }
        [XmlIgnore]
        public object Cell125 { get { if (_data125 != null) return _data125.Value; return null; } set { if (_data125 != null) 	_data125.Value = value; } }
        [XmlIgnore]
        public object Cell126 { get { if (_data126 != null) return _data126.Value; return null; } set { if (_data126 != null) 	_data126.Value = value; } }
        [XmlIgnore]
        public object Cell127 { get { if (_data127 != null) return _data127.Value; return null; } set { if (_data127 != null) 	_data127.Value = value; } }
        [XmlIgnore]
        public object Cell128 { get { if (_data128 != null) return _data128.Value; return null; } set { if (_data128 != null) 	_data128.Value = value; } }
        [XmlIgnore]
        public object Cell129 { get { if (_data129 != null) return _data129.Value; return null; } set { if (_data129 != null) 	_data129.Value = value; } }
        [XmlIgnore]
        public object Cell130 { get { if (_data130 != null) return _data130.Value; return null; } set { if (_data130 != null) 	_data130.Value = value; } }
        [XmlIgnore]
        public object Cell131 { get { if (_data131 != null) return _data131.Value; return null; } set { if (_data131 != null) 	_data131.Value = value; } }
        [XmlIgnore]
        public object Cell132 { get { if (_data132 != null) return _data132.Value; return null; } set { if (_data132 != null) 	_data132.Value = value; } }
        [XmlIgnore]
        public object Cell133 { get { if (_data133 != null) return _data133.Value; return null; } set { if (_data133 != null) 	_data133.Value = value; } }
        [XmlIgnore]
        public object Cell134 { get { if (_data134 != null) return _data134.Value; return null; } set { if (_data134 != null) 	_data134.Value = value; } }
        [XmlIgnore]
        public object Cell135 { get { if (_data135 != null) return _data135.Value; return null; } set { if (_data135 != null) 	_data135.Value = value; } }
        [XmlIgnore]
        public object Cell136 { get { if (_data136 != null) return _data136.Value; return null; } set { if (_data136 != null) 	_data136.Value = value; } }
        [XmlIgnore]
        public object Cell137 { get { if (_data137 != null) return _data137.Value; return null; } set { if (_data137 != null) 	_data137.Value = value; } }
        [XmlIgnore]
        public object Cell138 { get { if (_data138 != null) return _data138.Value; return null; } set { if (_data138 != null) 	_data138.Value = value; } }
        [XmlIgnore]
        public object Cell139 { get { if (_data139 != null) return _data139.Value; return null; } set { if (_data139 != null) 	_data139.Value = value; } }
        [XmlIgnore]
        public object Cell140 { get { if (_data140 != null) return _data140.Value; return null; } set { if (_data140 != null) 	_data140.Value = value; } }
        [XmlIgnore]
        public object Cell141 { get { if (_data141 != null) return _data141.Value; return null; } set { if (_data141 != null) 	_data141.Value = value; } }
        [XmlIgnore]
        public object Cell142 { get { if (_data142 != null) return _data142.Value; return null; } set { if (_data142 != null) 	_data142.Value = value; } }
        [XmlIgnore]
        public object Cell143 { get { if (_data143 != null) return _data143.Value; return null; } set { if (_data143 != null) 	_data143.Value = value; } }
        [XmlIgnore]
        public object Cell144 { get { if (_data144 != null) return _data144.Value; return null; } set { if (_data144 != null) 	_data144.Value = value; } }
        [XmlIgnore]
        public object Cell145 { get { if (_data145 != null) return _data145.Value; return null; } set { if (_data145 != null) 	_data145.Value = value; } }
        [XmlIgnore]
        public object Cell146 { get { if (_data146 != null) return _data146.Value; return null; } set { if (_data146 != null) 	_data146.Value = value; } }
        [XmlIgnore]
        public object Cell147 { get { if (_data147 != null) return _data147.Value; return null; } set { if (_data147 != null) 	_data147.Value = value; } }
        [XmlIgnore]
        public object Cell148 { get { if (_data148 != null) return _data148.Value; return null; } set { if (_data148 != null) 	_data148.Value = value; } }
        [XmlIgnore]
        public object Cell149 { get { if (_data149 != null) return _data149.Value; return null; } set { if (_data149 != null) 	_data149.Value = value; } }
        [XmlIgnore]
        public object Cell150 { get { if (_data150 != null) return _data150.Value; return null; } set { if (_data150 != null) 	_data150.Value = value; } }
        [XmlIgnore]
        public object Cell151 { get { if (_data151 != null) return _data151.Value; return null; } set { if (_data151 != null) 	_data151.Value = value; } }
        [XmlIgnore]
        public object Cell152 { get { if (_data152 != null) return _data152.Value; return null; } set { if (_data152 != null) 	_data152.Value = value; } }
        [XmlIgnore]
        public object Cell153 { get { if (_data153 != null) return _data153.Value; return null; } set { if (_data153 != null) 	_data153.Value = value; } }
        [XmlIgnore]
        public object Cell154 { get { if (_data154 != null) return _data154.Value; return null; } set { if (_data154 != null) 	_data154.Value = value; } }
        [XmlIgnore]
        public object Cell155 { get { if (_data155 != null) return _data155.Value; return null; } set { if (_data155 != null) 	_data155.Value = value; } }
        [XmlIgnore]
        public object Cell156 { get { if (_data156 != null) return _data156.Value; return null; } set { if (_data156 != null) 	_data156.Value = value; } }
        [XmlIgnore]
        public object Cell157 { get { if (_data157 != null) return _data157.Value; return null; } set { if (_data157 != null) 	_data157.Value = value; } }
        [XmlIgnore]
        public object Cell158 { get { if (_data158 != null) return _data158.Value; return null; } set { if (_data158 != null) 	_data158.Value = value; } }
        [XmlIgnore]
        public object Cell159 { get { if (_data159 != null) return _data159.Value; return null; } set { if (_data159 != null) 	_data159.Value = value; } }
        [XmlIgnore]
        public object Cell160 { get { if (_data160 != null) return _data160.Value; return null; } set { if (_data160 != null) 	_data160.Value = value; } }
        [XmlIgnore]
        public object Cell161 { get { if (_data161 != null) return _data161.Value; return null; } set { if (_data161 != null) 	_data161.Value = value; } }
        [XmlIgnore]
        public object Cell162 { get { if (_data162 != null) return _data162.Value; return null; } set { if (_data162 != null) 	_data162.Value = value; } }
        [XmlIgnore]
        public object Cell163 { get { if (_data163 != null) return _data163.Value; return null; } set { if (_data163 != null) 	_data163.Value = value; } }
        [XmlIgnore]
        public object Cell164 { get { if (_data164 != null) return _data164.Value; return null; } set { if (_data164 != null) 	_data164.Value = value; } }
        [XmlIgnore]
        public object Cell165 { get { if (_data165 != null) return _data165.Value; return null; } set { if (_data165 != null) 	_data165.Value = value; } }
        [XmlIgnore]
        public object Cell166 { get { if (_data166 != null) return _data166.Value; return null; } set { if (_data166 != null) 	_data166.Value = value; } }
        [XmlIgnore]
        public object Cell167 { get { if (_data167 != null) return _data167.Value; return null; } set { if (_data167 != null) 	_data167.Value = value; } }
        [XmlIgnore]
        public object Cell168 { get { if (_data168 != null) return _data168.Value; return null; } set { if (_data168 != null) 	_data168.Value = value; } }
        [XmlIgnore]
        public object Cell169 { get { if (_data169 != null) return _data169.Value; return null; } set { if (_data169 != null) 	_data169.Value = value; } }
        [XmlIgnore]
        public object Cell170 { get { if (_data170 != null) return _data170.Value; return null; } set { if (_data170 != null) 	_data170.Value = value; } }
        [XmlIgnore]
        public object Cell171 { get { if (_data171 != null) return _data171.Value; return null; } set { if (_data171 != null) 	_data171.Value = value; } }
        [XmlIgnore]
        public object Cell172 { get { if (_data172 != null) return _data172.Value; return null; } set { if (_data172 != null) 	_data172.Value = value; } }
        [XmlIgnore]
        public object Cell173 { get { if (_data173 != null) return _data173.Value; return null; } set { if (_data173 != null) 	_data173.Value = value; } }
        [XmlIgnore]
        public object Cell174 { get { if (_data174 != null) return _data174.Value; return null; } set { if (_data174 != null) 	_data174.Value = value; } }
        [XmlIgnore]
        public object Cell175 { get { if (_data175 != null) return _data175.Value; return null; } set { if (_data175 != null) 	_data175.Value = value; } }
        [XmlIgnore]
        public object Cell176 { get { if (_data176 != null) return _data176.Value; return null; } set { if (_data176 != null) 	_data176.Value = value; } }
        [XmlIgnore]
        public object Cell177 { get { if (_data177 != null) return _data177.Value; return null; } set { if (_data177 != null) 	_data177.Value = value; } }
        [XmlIgnore]
        public object Cell178 { get { if (_data178 != null) return _data178.Value; return null; } set { if (_data178 != null) 	_data178.Value = value; } }
        [XmlIgnore]
        public object Cell179 { get { if (_data179 != null) return _data179.Value; return null; } set { if (_data179 != null) 	_data179.Value = value; } }
        [XmlIgnore]
        public object Cell180 { get { if (_data180 != null) return _data180.Value; return null; } set { if (_data180 != null) 	_data180.Value = value; } }
        [XmlIgnore]
        public object Cell181 { get { if (_data181 != null) return _data181.Value; return null; } set { if (_data181 != null) 	_data181.Value = value; } }
        [XmlIgnore]
        public object Cell182 { get { if (_data182 != null) return _data182.Value; return null; } set { if (_data182 != null) 	_data182.Value = value; } }
        [XmlIgnore]
        public object Cell183 { get { if (_data183 != null) return _data183.Value; return null; } set { if (_data183 != null) 	_data183.Value = value; } }
        [XmlIgnore]
        public object Cell184 { get { if (_data184 != null) return _data184.Value; return null; } set { if (_data184 != null) 	_data184.Value = value; } }
        [XmlIgnore]
        public object Cell185 { get { if (_data185 != null) return _data185.Value; return null; } set { if (_data185 != null) 	_data185.Value = value; } }
        [XmlIgnore]
        public object Cell186 { get { if (_data186 != null) return _data186.Value; return null; } set { if (_data186 != null) 	_data186.Value = value; } }
        [XmlIgnore]
        public object Cell187 { get { if (_data187 != null) return _data187.Value; return null; } set { if (_data187 != null) 	_data187.Value = value; } }
        [XmlIgnore]
        public object Cell188 { get { if (_data188 != null) return _data188.Value; return null; } set { if (_data188 != null) 	_data188.Value = value; } }
        [XmlIgnore]
        public object Cell189 { get { if (_data189 != null) return _data189.Value; return null; } set { if (_data189 != null) 	_data189.Value = value; } }
        [XmlIgnore]
        public object Cell190 { get { if (_data190 != null) return _data190.Value; return null; } set { if (_data190 != null) 	_data190.Value = value; } }
        [XmlIgnore]
        public object Cell191 { get { if (_data191 != null) return _data191.Value; return null; } set { if (_data191 != null) 	_data191.Value = value; } }
        [XmlIgnore]
        public object Cell192 { get { if (_data192 != null) return _data192.Value; return null; } set { if (_data192 != null) 	_data192.Value = value; } }
        [XmlIgnore]
        public object Cell193 { get { if (_data193 != null) return _data193.Value; return null; } set { if (_data193 != null) 	_data193.Value = value; } }
        [XmlIgnore]
        public object Cell194 { get { if (_data194 != null) return _data194.Value; return null; } set { if (_data194 != null) 	_data194.Value = value; } }
        [XmlIgnore]
        public object Cell195 { get { if (_data195 != null) return _data195.Value; return null; } set { if (_data195 != null) 	_data195.Value = value; } }
        [XmlIgnore]
        public object Cell196 { get { if (_data196 != null) return _data196.Value; return null; } set { if (_data196 != null) 	_data196.Value = value; } }
        [XmlIgnore]
        public object Cell197 { get { if (_data197 != null) return _data197.Value; return null; } set { if (_data197 != null) 	_data197.Value = value; } }
        [XmlIgnore]
        public object Cell198 { get { if (_data198 != null) return _data198.Value; return null; } set { if (_data198 != null) 	_data198.Value = value; } }
        [XmlIgnore]
        public object Cell199 { get { if (_data199 != null) return _data199.Value; return null; } set { if (_data199 != null) 	_data199.Value = value; } }
        [XmlIgnore]
        public object Cell200 { get { if (_data200 != null) return _data200.Value; return null; } set { if (_data200 != null) 	_data200.Value = value; } }

        #endregion

        #endregion

        public abstract DynamicData CopyKeyMembers(DynamicData data);

    }

    #region Default Dynamic Column Dto

    public interface IDefaultDynamicData
    {
        string RowCode { get; set; }
    }

    [Serializable]
    public class DefaultDynamicData : OneLevelColumnData, IDefaultDynamicData
    {
        #region IDefaultDynamicData Member(s)

        public string RowCode { get; set; }

        #endregion

        public string RowName { get; set; }

        public override bool IsSameRow(BufferColumnDto dto)
        {
            IDefaultDynamicData that = dto as IDefaultDynamicData;
            if (that == null) return false;
            return this.RowCode.Equals(that.RowCode);
        }
        public override DynamicData CopyKeyMembers(DynamicData data)
        {
            IDefaultDynamicData that = data as IDefaultDynamicData;
            if (that == null) return null;
            that.RowCode = this.RowCode;
            return data;
        }
    }

    [Serializable]
    public class DefaultDynamicColumnDto : BufferColumnDto, IDefaultDynamicData
    {
        #region IDefaultDynamicData Member(s)

        public string RowCode { get; set; }

        #endregion

        public string RowName { get; set; }
        //
        public override DynamicData CopyKeyMembers(DynamicData data)
        {
            IDefaultDynamicData that = data as IDefaultDynamicData;
            if (that == null) return null;
            that.RowCode = this.RowCode;
            return data;
        }
        //
    }

    #endregion

    # region  Add by seo_jungro 2010-06-25

    [Serializable]
    public class TwoLevelDynamicData : TwoLevelColumnData, IDefaultDynamicData
    {
        #region IDefaultDynamicData Member(s)

        public string RowCode { get; set; }

        #endregion

        public string RowName { get; set; }

        public override bool IsSameRow(BufferColumnDto dto)
        {
            IDefaultDynamicData that = dto as IDefaultDynamicData;
            if (that == null) return false;
            return this.RowCode.Equals(that.RowCode);
        }

        public override DynamicData CopyKeyMembers(DynamicData data)
        {
            IDefaultDynamicData that = data as IDefaultDynamicData;
            if (that == null) return null;
            that.RowCode = this.RowCode;
            return data;
        }
    }

    # endregion
}
