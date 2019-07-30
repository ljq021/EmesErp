export function camelCaseJSONKey(jsonObj) {
  const result = {};
  // tslint:disable-next-line:forin
  for (let key in jsonObj) {
    let keyval = jsonObj[key];
    if (typeof jsonObj[key] === 'object') {
      keyval = camelCaseJSONKey(jsonObj[key]);
    }

    key = key.replace(key[0], key[0].toLowerCase());
    result[key] = keyval;
  }
  return result;
}
export function isJson(str) {
  try {
    if (typeof JSON.parse(str) === 'object') {
      return true;
    }
  } catch (e) {}
  return false;
}
