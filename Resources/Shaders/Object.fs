precision mediump float;
attribute vec2 a_uv;
uniform sampler 2D u_texture;
void main()
{
	//gl_FragColor = vec4(1.0, 0.0, 0.0, 1.0);
	gl_FragColor = texture2D(u_texture, v_uv);
}
