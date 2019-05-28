import request from '@/utils/request';

export async function getBugUrgencys() {
  return request('/api/bugUrgencys');
}
