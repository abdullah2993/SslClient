namespace Ssl.Packet
{
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"SSL_DetectionBall")]
    public partial class SSL_DetectionBall : global::ProtoBuf.IExtensible
    {
        public SSL_DetectionBall()
        {
        }

        private float _confidence;

        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"confidence",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float confidence
        {
            get { return _confidence; }
            set { _confidence = value; }
        }

        private uint _area = default(uint);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"area",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint area
        {
            get { return _area; }
            set { _area = value; }
        }

        private float _x;

        [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name = @"x",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float x
        {
            get { return _x; }
            set { _x = value; }
        }

        private float _y;

        [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name = @"y",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float y
        {
            get { return _y; }
            set { _y = value; }
        }

        private float _z = default(float);

        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"z",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float z
        {
            get { return _z; }
            set { _z = value; }
        }

        private float _pixel_x;

        [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name = @"pixel_x",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float pixel_x
        {
            get { return _pixel_x; }
            set { _pixel_x = value; }
        }

        private float _pixel_y;

        [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name = @"pixel_y",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float pixel_y
        {
            get { return _pixel_y; }
            set { _pixel_y = value; }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"SSL_DetectionRobot")]
    public partial class SSL_DetectionRobot : global::ProtoBuf.IExtensible
    {
        public SSL_DetectionRobot()
        {
        }

        private float _confidence;

        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"confidence",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float confidence
        {
            get { return _confidence; }
            set { _confidence = value; }
        }

        private uint _robot_id = default(uint);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"robot_id",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint robot_id
        {
            get { return _robot_id; }
            set { _robot_id = value; }
        }

        private float _x;

        [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name = @"x",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float x
        {
            get { return _x; }
            set { _x = value; }
        }

        private float _y;

        [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name = @"y",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float y
        {
            get { return _y; }
            set { _y = value; }
        }

        private float _orientation = default(float);

        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"orientation",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float orientation
        {
            get { return _orientation; }
            set { _orientation = value; }
        }

        private float _pixel_x;

        [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name = @"pixel_x",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float pixel_x
        {
            get { return _pixel_x; }
            set { _pixel_x = value; }
        }

        private float _pixel_y;

        [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name = @"pixel_y",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float pixel_y
        {
            get { return _pixel_y; }
            set { _pixel_y = value; }
        }

        private float _height = default(float);

        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name = @"height",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float height
        {
            get { return _height; }
            set { _height = value; }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"SSL_DetectionFrame")]
    public partial class SSL_DetectionFrame : global::ProtoBuf.IExtensible
    {
        public SSL_DetectionFrame()
        {
        }

        private uint _frame_number;

        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"frame_number",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public uint frame_number
        {
            get { return _frame_number; }
            set { _frame_number = value; }
        }

        private double _t_capture;

        [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name = @"t_capture",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public double t_capture
        {
            get { return _t_capture; }
            set { _t_capture = value; }
        }

        private double _t_sent;

        [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name = @"t_sent",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public double t_sent
        {
            get { return _t_sent; }
            set { _t_sent = value; }
        }

        private uint _camera_id;

        [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name = @"camera_id",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public uint camera_id
        {
            get { return _camera_id; }
            set { _camera_id = value; }
        }

        private readonly global::System.Collections.Generic.List<SSL_DetectionBall> _balls =
            new global::System.Collections.Generic.List<SSL_DetectionBall>();

        [global::ProtoBuf.ProtoMember(5, Name = @"balls", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<SSL_DetectionBall> balls
        {
            get { return _balls; }
        }

        private readonly global::System.Collections.Generic.List<SSL_DetectionRobot> _robots_yellow =
            new global::System.Collections.Generic.List<SSL_DetectionRobot>();

        [global::ProtoBuf.ProtoMember(6, Name = @"robots_yellow", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<SSL_DetectionRobot> robots_yellow
        {
            get { return _robots_yellow; }
        }

        private readonly global::System.Collections.Generic.List<SSL_DetectionRobot> _robots_blue =
            new global::System.Collections.Generic.List<SSL_DetectionRobot>();

        [global::ProtoBuf.ProtoMember(7, Name = @"robots_blue", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<SSL_DetectionRobot> robots_blue
        {
            get { return _robots_blue; }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"SSL_GeometryFieldSize")]
    public partial class SSL_GeometryFieldSize : global::ProtoBuf.IExtensible
    {
        public SSL_GeometryFieldSize()
        {
        }

        private int _line_width;

        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"line_width",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int line_width
        {
            get { return _line_width; }
            set { _line_width = value; }
        }

        private int _field_length;

        [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name = @"field_length",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int field_length
        {
            get { return _field_length; }
            set { _field_length = value; }
        }

        private int _field_width;

        [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name = @"field_width",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int field_width
        {
            get { return _field_width; }
            set { _field_width = value; }
        }

        private int _boundary_width;

        [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name = @"boundary_width",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int boundary_width
        {
            get { return _boundary_width; }
            set { _boundary_width = value; }
        }

        private int _referee_width;

        [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name = @"referee_width",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int referee_width
        {
            get { return _referee_width; }
            set { _referee_width = value; }
        }

        private int _goal_width;

        [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name = @"goal_width",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int goal_width
        {
            get { return _goal_width; }
            set { _goal_width = value; }
        }

        private int _goal_depth;

        [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name = @"goal_depth",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int goal_depth
        {
            get { return _goal_depth; }
            set { _goal_depth = value; }
        }

        private int _goal_wall_width;

        [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name = @"goal_wall_width",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int goal_wall_width
        {
            get { return _goal_wall_width; }
            set { _goal_wall_width = value; }
        }

        private int _center_circle_radius;

        [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name = @"center_circle_radius",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int center_circle_radius
        {
            get { return _center_circle_radius; }
            set { _center_circle_radius = value; }
        }

        private int _defense_radius;

        [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name = @"defense_radius",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int defense_radius
        {
            get { return _defense_radius; }
            set { _defense_radius = value; }
        }

        private int _defense_stretch;

        [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name = @"defense_stretch",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int defense_stretch
        {
            get { return _defense_stretch; }
            set { _defense_stretch = value; }
        }

        private int _free_kick_from_defense_dist;

        [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name = @"free_kick_from_defense_dist",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int free_kick_from_defense_dist
        {
            get { return _free_kick_from_defense_dist; }
            set { _free_kick_from_defense_dist = value; }
        }

        private int _penalty_spot_from_field_line_dist;

        [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name = @"penalty_spot_from_field_line_dist",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int penalty_spot_from_field_line_dist
        {
            get { return _penalty_spot_from_field_line_dist; }
            set { _penalty_spot_from_field_line_dist = value; }
        }

        private int _penalty_line_from_spot_dist;

        [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name = @"penalty_line_from_spot_dist",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int penalty_line_from_spot_dist
        {
            get { return _penalty_line_from_spot_dist; }
            set { _penalty_line_from_spot_dist = value; }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"SSL_GeometryCameraCalibration")]
    public partial class SSL_GeometryCameraCalibration : global::ProtoBuf.IExtensible
    {
        public SSL_GeometryCameraCalibration()
        {
        }

        private uint _camera_id;

        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"camera_id",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public uint camera_id
        {
            get { return _camera_id; }
            set { _camera_id = value; }
        }

        private float _focal_length;

        [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name = @"focal_length",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float focal_length
        {
            get { return _focal_length; }
            set { _focal_length = value; }
        }

        private float _principal_point_x;

        [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name = @"principal_point_x",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float principal_point_x
        {
            get { return _principal_point_x; }
            set { _principal_point_x = value; }
        }

        private float _principal_point_y;

        [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name = @"principal_point_y",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float principal_point_y
        {
            get { return _principal_point_y; }
            set { _principal_point_y = value; }
        }

        private float _distortion;

        [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name = @"distortion",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float distortion
        {
            get { return _distortion; }
            set { _distortion = value; }
        }

        private float _q0;

        [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name = @"q0",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float q0
        {
            get { return _q0; }
            set { _q0 = value; }
        }

        private float _q1;

        [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name = @"q1",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float q1
        {
            get { return _q1; }
            set { _q1 = value; }
        }

        private float _q2;

        [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name = @"q2",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float q2
        {
            get { return _q2; }
            set { _q2 = value; }
        }

        private float _q3;

        [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name = @"q3",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float q3
        {
            get { return _q3; }
            set { _q3 = value; }
        }

        private float _tx;

        [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name = @"tx",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float tx
        {
            get { return _tx; }
            set { _tx = value; }
        }

        private float _ty;

        [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name = @"ty",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float ty
        {
            get { return _ty; }
            set { _ty = value; }
        }

        private float _tz;

        [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name = @"tz",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public float tz
        {
            get { return _tz; }
            set { _tz = value; }
        }

        private float _derived_camera_world_tx = default(float);

        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name = @"derived_camera_world_tx",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float derived_camera_world_tx
        {
            get { return _derived_camera_world_tx; }
            set { _derived_camera_world_tx = value; }
        }

        private float _derived_camera_world_ty = default(float);

        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name = @"derived_camera_world_ty",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float derived_camera_world_ty
        {
            get { return _derived_camera_world_ty; }
            set { _derived_camera_world_ty = value; }
        }

        private float _derived_camera_world_tz = default(float);

        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name = @"derived_camera_world_tz",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float derived_camera_world_tz
        {
            get { return _derived_camera_world_tz; }
            set { _derived_camera_world_tz = value; }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"SSL_GeometryData")]
    public partial class SSL_GeometryData : global::ProtoBuf.IExtensible
    {
        public SSL_GeometryData()
        {
        }

        private SSL_GeometryFieldSize _field;

        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"field",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        public SSL_GeometryFieldSize field
        {
            get { return _field; }
            set { _field = value; }
        }

        private readonly global::System.Collections.Generic.List<SSL_GeometryCameraCalibration> _calib =
            new global::System.Collections.Generic.List<SSL_GeometryCameraCalibration>();

        [global::ProtoBuf.ProtoMember(2, Name = @"calib", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<SSL_GeometryCameraCalibration> calib
        {
            get { return _calib; }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
        }
    }


    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"Log_Frame")]
    public partial class Log_Frame : global::ProtoBuf.IExtensible
    {
        public Log_Frame()
        {
        }

        private SSL_DetectionFrame _frame;

        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"frame",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        public SSL_DetectionFrame frame
        {
            get { return _frame; }
            set { _frame = value; }
        }

        private string _refbox_cmd;

        [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name = @"refbox_cmd",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        public string refbox_cmd
        {
            get { return _refbox_cmd; }
            set { _refbox_cmd = value; }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"Refbox_Log")]
    public partial class Refbox_Log : global::ProtoBuf.IExtensible
    {
        public Refbox_Log()
        {
        }

        private readonly global::System.Collections.Generic.List<Log_Frame> _log =
            new global::System.Collections.Generic.List<Log_Frame>();

        [global::ProtoBuf.ProtoMember(1, Name = @"log", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Log_Frame> log
        {
            get { return _log; }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
        }
    }


    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"SSL_WrapperPacket")]
    public partial class SSL_WrapperPacket : global::ProtoBuf.IExtensible
    {
        public SSL_WrapperPacket()
        {
        }

        private SSL_DetectionFrame _detection = null;

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"detection",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public SSL_DetectionFrame detection
        {
            get { return _detection; }
            set { _detection = value; }
        }

        private SSL_GeometryData _geometry = null;

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"geometry",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public SSL_GeometryData geometry
        {
            get { return _geometry; }
            set { _geometry = value; }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
        }
    }
}