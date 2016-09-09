using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static class MediaPacket
    {
        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_create")]
        internal static extern int Create(IntPtr format, IntPtr finalizeCb, IntPtr cbData, out IntPtr handle);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_alloc")]
        internal static extern int Alloc(IntPtr handle);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_destroy")]
        internal static extern int Destroy(IntPtr handle);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_get_format")]
        internal static extern int GetFormat(IntPtr handle, out IntPtr format);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_get_buffer_data_ptr")]
        internal static extern int GetBufferData(IntPtr handle, out IntPtr dataHandle);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_get_buffer_size")]
        internal static extern int GetBufferSize(IntPtr handle, out ulong size);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_set_buffer_size")]
        internal static extern int SetBufferSize(IntPtr handle, ulong size);


        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_get_allocated_buffer_size")]
        internal static extern int GetAllocatedBufferSize(IntPtr handle, out int size);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_get_number_of_video_planes")]
        internal static extern int GetNumberOfVideoPlanes(IntPtr handle, out uint num);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_get_video_stride_width")]
        internal static extern int GetVideoStrideWidth(IntPtr handle, int planeIndex, out int value);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_get_video_stride_height")]
        internal static extern int GetVideoStrideHeight(IntPtr handle, int planeIndex, out int value);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_get_video_plane_data_ptr")]
        internal static extern int GetVideoPlaneData(IntPtr handle, int planeIndex, out IntPtr dataHandle);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_is_encoded")]
        internal static extern int IsEncoded(IntPtr handle, out bool value);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_get_flags")]
        internal static extern int GetBufferFlags(IntPtr handle, out int value);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_set_flags")]
        internal static extern int SetBufferFlags(IntPtr handle, int value);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_reset_flags")]
        internal static extern int ResetBufferFlags(IntPtr handle);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_get_pts")]
        internal static extern int GetPts(IntPtr handle, out ulong value);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_get_dts")]
        internal static extern int GetDts(IntPtr handle, out ulong value);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_set_pts")]
        internal static extern int SetPts(IntPtr handle, ulong value);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_set_dts")]
        internal static extern int SetDts(IntPtr handle, ulong value);


        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_set_extra")]
        internal static extern int SetExtra(IntPtr handle, IntPtr value);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_packet_get_extra")]
        internal static extern int GetExtra(IntPtr handle, out IntPtr value);
    }

    internal static class MediaFormat
    {
        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_create")]
        internal static extern int Create(out IntPtr handle);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_unref")]
        internal static extern int Unref(IntPtr handle);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_get_type")]
        internal static extern int GetType(IntPtr handle, out int type);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_get_container_mime")]
        internal static extern int GetContainerMimeType(IntPtr handle, out int mimeType);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_set_container_mime")]
        internal static extern int SetContainerMimeType(IntPtr handle, int mimeType);

        #region Video apis
        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_get_video_info")]
        internal static extern int GetVideoInfo(IntPtr handle, out int mimeType,
            out int width, out int height, out int averageBps, out int maxBps);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_get_video_frame_rate")]
        internal static extern int GetVideoFrameRate(IntPtr handle, out int frameRate);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_set_video_mime")]
        internal static extern int SetVideoMimeType(IntPtr handle, int value);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_set_video_width")]
        internal static extern int SetVideoWidth(IntPtr handle, int value);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_set_video_height")]
        internal static extern int SetVideoHeight(IntPtr handle, int value);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_set_video_avg_bps")]
        internal static extern int SetVideoAverageBps(IntPtr handle, int value);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_set_video_frame_rate")]
        internal static extern int SetVideoFrameRate(IntPtr handle, int value);
        #endregion

        #region Audio apis
        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_get_audio_info")]
        internal static extern int GetAudioInfo(IntPtr handle, out int mimeType,
            out int channel, out int sampleRate, out int bit, out int averageBps);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_get_audio_aac_header_type")]
        internal static extern int GetAudioAacType(IntPtr handle, out int aacType);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_set_audio_mime")]
        internal static extern int SetAudioMimeType(IntPtr handle, int value);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_set_audio_channel")]
        internal static extern int SetAudioChannel(IntPtr handle, int value);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_set_audio_samplerate")]
        internal static extern int SetAudioSampleRate(IntPtr handle, int value);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_set_audio_bit")]
        internal static extern int SetAudioBit(IntPtr handle, int value);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_set_audio_avg_bps")]
        internal static extern int SetAudioAverageBps(IntPtr handle, int value);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_set_audio_aac_header_type")]
        internal static extern int SetAudioAacType(IntPtr handle, int value);
        #endregion

        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_get_text_info")]
        internal static extern int GetTextInfo(IntPtr handle, out int mimeType, out int textType);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_set_text_mime")]
        internal static extern int SetTextMimeType(IntPtr handle, int value);

        [DllImport(Libraries.MediaTool, EntryPoint = "media_format_set_text_type")]
        internal static extern int SetTextType(IntPtr handle, int value);
    }
}
