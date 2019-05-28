import { getBugUrgencys } from '@/services/bug';

export default {
  namespace: 'bug',

  state: {
    list: []
  },

  effects: {
    *getBugUrgencys(_, { call, put }) {
      const response = yield call(getBugUrgencys);
      yield put({
        type: 'save',
        payload: response,
      });
    },
  },

  reducers: {
    save(state, action) {
      return {
        ...state,
        list: action.payload,
      };
    },
  },
};
