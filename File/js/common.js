function doZoom(size) {
	document.getElementById('zoomtext').style.fontSize=size+'px';
}

function loading(l,t){
	var long = l || '100%';
	var time = t || 1000;
	$('.loading').clearQueue();
	$('.loading').animate({'width':long},time);
}

function imgError(obj){
	obj.src='/template/default/plus/z_portal/images/defaultimg.png';
	obj.onerror = null;//����onerror�¼�ֻ����һ��
}