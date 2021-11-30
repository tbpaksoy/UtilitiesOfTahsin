using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System;
using UnityRandom = UnityEngine.Random;
using UnityObject = UnityEngine.Object;

namespace LibraryOfTahsin
{
    public static partial class UtilitiesOfTahsin
    {
        public static void GridSnapXZ(ref Vector3 position, Vector3 inputPosition)
        {
            float x = Mathf.Ceil(inputPosition.x);
            float z = Mathf.Ceil(inputPosition.z);
            position = new Vector3(x, position.y, z);
        }
        public static void GridSnapXZ(float height, ref Vector3 position, Vector3 inputPosition)
        {
            float x = Mathf.Ceil(inputPosition.x);
            float z = Mathf.Ceil(inputPosition.z);
            position = new Vector3(x, height, z);
        }
        public static void GridSnapXZ(ref Vector3 position, Vector3 inputPosition, float gridSize)
        {
            float x = Mathf.Ceil(inputPosition.x / gridSize) * gridSize;
            float z = Mathf.Ceil(inputPosition.z / gridSize) * gridSize;
            position = new Vector3(x, position.y, z);
        }
        public static void GridSnapXZ(float height, ref Vector3 position, Vector3 inputPosition, float gridSize)
        {
            float x = Mathf.Ceil(inputPosition.x / gridSize) * gridSize;
            float z = Mathf.Ceil(inputPosition.z / gridSize) * gridSize;
            position = new Vector3(x, height, z);
        }
        public static void GridSnapXYZ(ref Vector3 position, Vector3 inputPosition)
        {
            float x = Mathf.Ceil(inputPosition.x);
            float y = Mathf.Ceil(inputPosition.y);
            float z = Mathf.Ceil(inputPosition.z);
            position = new Vector3(x, y, z);
        }
        public static void GridSnapXYZ(ref Vector3 position, Vector3 inputPosition, float gridSize)
        {
            float x = Mathf.Ceil(inputPosition.x / gridSize) * gridSize;
            float y = Mathf.Ceil(inputPosition.y / gridSize) * gridSize;
            float z = Mathf.Ceil(inputPosition.z / gridSize) * gridSize;
            position = new Vector3(x, y, z);
        }
        public static void SendObjectToOtherList(ref List<object> from, ref List<object> to, object @object)
        {
            if (from.GetType() == to.GetType() && from.Contains(@object))
            {
                from.Remove(@object);
                to.Add(@object);
            }
        }
        public static Vector2 GetRandomVector2(float xMin, float xMax, float yMin, float yMax)
        {
            return new Vector2(UnityRandom.Range(xMin, xMax), UnityRandom.Range(yMin, yMax));
        }
        public static Vector2 GetRandomVector2Between2Points(Vector2 a, Vector2 b)
        {
            return Vector2.Lerp(a, b, UnityRandom.Range(0, 1));
        }
        public static Vector3 DetectPoint()
        {
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hitInfo, float.MaxValue);
            return hitInfo.point;
        }
        public static Vector3 DetectPoint(LayerMask layerMask)
        {
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hitInfo, float.MaxValue, layerMask);
            return hitInfo.point;
        }
        public static Vector3 DetectPoint(string maskName)
        {
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hitInfo, float.MaxValue, LayerMask.NameToLayer(maskName));
            return hitInfo.point;
        }
        public static Vector3 DetectPoint(float range)
        {
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hitInfo, range);
            return hitInfo.point;
        }
        public static Vector3 DetectPoint(float range, LayerMask layerMask)
        {
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hitInfo, range, layerMask);
            return hitInfo.point;
        }
        public static Vector3 DetectPoint(float range, string maskName)
        {
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hitInfo, range, LayerMask.GetMask(maskName));
            return hitInfo.point;
        }
        public static Vector3 DetectPoint(Camera camera)
        {
            Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition), out RaycastHit hitInfo, float.MaxValue);
            return hitInfo.point;
        }
        public static Vector3 DetectPoint(Camera camera, LayerMask layerMask)
        {
            Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition), out RaycastHit hitInfo, float.MaxValue, layerMask);
            return hitInfo.point;
        }
        public static Vector3 DetectPoint(Camera camera, float range, LayerMask layerMask)
        {
            Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition), out RaycastHit hitInfo, range, layerMask);
            return hitInfo.point;
        }
        public static Vector3 CalculateDirection(Vector3 from, Vector3 to)
        {
            return (to - from).normalized;
        }
        public static Vector3 GetRandomVector3(float xMin, float xMax, float yMin, float yMax, float zMin, float zMax)
        {
            return new Vector3(UnityRandom.Range(xMin, xMax), UnityRandom.Range(yMin, yMax), UnityRandom.Range(zMin, zMax));
        }
        public static Vector3 GetRandomVector3Between2Points(Vector3 a, Vector3 b)
        {
            return Vector3.Lerp(a, b, UnityRandom.Range(0, 1));
        }
        public static Vector3 ReturnGridVector(Vector3 source, bool snapX, bool snapY, bool snapZ)
        {
            if (snapX) source.x = Mathf.Ceil(source.x);
            if (snapY) source.y = Mathf.Ceil(source.y);
            if (snapZ) source.z = Mathf.Ceil(source.z);
            return source;
        }
        public static Vector3 ReturnGridVector(Vector3 source, float gridSize, bool snapX, bool snapY, bool snapZ)
        {
            if (snapX) source.x = Mathf.Ceil(source.x / gridSize) * gridSize;
            if (snapY) source.y = Mathf.Ceil(source.y / gridSize) * gridSize;
            if (snapZ) source.z = Mathf.Ceil(source.z / gridSize) * gridSize;
            return source;
        }
        public static GameObject InstantiateRandomGameObject(List<GameObject> objects)
        {
            int index = UnityRandom.Range(0, objects.Count);
            return UnityObject.Instantiate(objects[index]);
        }
        public static GameObject InstantiateRandomGameObject(GameObject[] objects)
        {
            int index = UnityRandom.Range(0, objects.Length);
            return UnityObject.Instantiate(objects[index]);
        }
        public static GameObject InstantiateRandomGameObject(List<GameObject> objects, Vector3 position)
        {
            int index = UnityRandom.Range(0, objects.Count);
            return UnityObject.Instantiate(objects[index], position, Quaternion.identity);
        }
        public static GameObject InstantiateRandomGameObject(GameObject[] objects, Vector3 position)
        {
            int index = UnityRandom.Range(0, objects.Length);
            return UnityObject.Instantiate(objects[index], position, Quaternion.identity);
        }
        public static GameObject InstantiateRandomGameObject(List<GameObject> objects, Vector3 position, Quaternion rotation)
        {
            int index = UnityRandom.Range(0, objects.Count);
            return UnityObject.Instantiate(objects[index], position, rotation);
        }
        public static GameObject InstantiateRandomGameObject(GameObject[] objects, Vector3 position, Quaternion rotation)
        {
            int index = UnityRandom.Range(0, objects.Length);
            return UnityObject.Instantiate(objects[index], position, rotation);
        }
        public static GameObject InstantiateRandomGameObject(IList<GameObject> objects, Vector3 position)
        {
            int index = UnityRandom.Range(0, objects.Count);
            return UnityObject.Instantiate(objects[index], position, Quaternion.identity);
        }
        public static GameObject InstantiateRandomGameObject(IList<GameObject> objects, Vector3 position, Quaternion rotation)
        {
            int index = UnityRandom.Range(0, objects.Count);
            return UnityObject.Instantiate(objects[index], position, rotation);
        }
        public static GameObject InstantiateRandomGameObject(IList<GameObject> objects)
        {
            int index = UnityRandom.Range(0, objects.Count);
            return UnityObject.Instantiate(objects[index]);
        }
        public static GameObject CreateAndInstantiateGameObject(params Component[] componentTypes)
        {
            GameObject gameObject = new GameObject();
            foreach (Component component in componentTypes)
            {
                gameObject.AddComponent(component.GetType());
            }
            return UnityObject.Instantiate(gameObject);
        }
        public static GameObject CreateAndInstantiateGameObject(Vector3 position, params Component[] components)
        {
            GameObject gameObject = new GameObject();
            foreach (Component component in components)
            {
                gameObject.AddComponent(component.GetType());
            }
            return UnityObject.Instantiate(gameObject, position, Quaternion.identity);
        }
        public static float CalculateDistanceOnX(Vector3 positionA, Vector3 positionB)
        {
            return Mathf.Abs(positionA.x - positionB.x);
        }
        public static float CalculateDistanceOnY(Vector3 positionA, Vector3 positionB)
        {
            return Mathf.Abs(positionA.y - positionB.y);
        }
        public static float CalculateDistanceOnZ(Vector3 positionA, Vector3 positionB)
        {
            return Mathf.Abs(positionA.z - positionB.z);
        }
        public static float CalculateAngle360OnX(Vector3 a, Vector3 b)
        {
            if (a != b)
            {
                float result = Mathf.Rad2Deg * Mathf.Acos((a.y * b.y + a.z * b.z) / Mathf.Sqrt((a.y * a.y + a.z * a.z) * (b.y * b.y + b.z * b.z)));
                if (b.x < a.x)
                {
                    result += 180;
                }
                return result;
            }

            return float.NaN;
        }
        public static float CalculateAngle360OnX(Vector3 a, Vector3 b, Vector3 origin)
        {
            if (a != b)
            {
                a -= origin;
                b -= origin;
                float result = Mathf.Rad2Deg * Mathf.Acos((a.y * b.y + a.z * b.z) / Mathf.Sqrt((a.y * a.y + a.z * a.z) * (b.y * b.y + b.z * b.z)));
                if (b.x < a.x)
                {
                    result += 180;
                }
                return result;
            }
            return float.NaN;
        }
        public static float CalculateAngle180OnX(Vector3 a, Vector3 b)
        {
            if (a != b)
            {
                float result = Mathf.Rad2Deg * Mathf.Acos((a.y * b.y + a.z * b.z) / Mathf.Sqrt((a.y * a.y + a.z * a.z) * (b.y * b.y + b.z * b.z)));
                return result;
            }

            return 0f;
        }
        public static float CalculateAngle180OnX(Vector3 a, Vector3 b, Vector3 origin)
        {
            if (a != b)
            {
                a -= origin;
                b -= origin;
                if (a != b)
                {
                    float result = Mathf.Rad2Deg * Mathf.Acos((a.y * b.y + a.z * b.z) / Mathf.Sqrt((a.y * a.y + a.z * a.z) * (b.y * b.y + b.z * b.z)));
                    return result;
                }
            }
            return float.NaN;
        }
        public static float CalculateAngle360OnY(Vector3 a, Vector3 b)
        {
            if (a != b)
            {
                float result = Mathf.Rad2Deg * Mathf.Acos((a.x * b.x + a.z * b.z) / Mathf.Sqrt((a.x * a.x + a.z * a.z) * (b.x * b.x + b.z * b.z)));
                if (b.z < a.z)
                {
                    result += 180;
                }
                return result;
            }

            return float.NaN;
        }
        public static float CalculateAngle360OnY(Vector3 a, Vector3 b, Vector3 origin)
        {
            if (a != b)
            {
                a -= origin;
                b -= origin;
                float result = Mathf.Rad2Deg * Mathf.Acos((a.x * b.x + a.z * b.z) / Mathf.Sqrt((a.x * a.x + a.z * a.z) * (b.x * b.x + b.z * b.z)));
                if (b.z < a.z)
                {
                    result += 180;
                }
                return result;
            }
            return float.NaN;
        }
        public static float CalculateAngle180OnY(Vector3 a, Vector3 b)
        {
            if (a != b)
            {
                float result = Mathf.Rad2Deg * Mathf.Acos((a.x * b.x + a.z * b.z) / Mathf.Sqrt((a.x * a.x + a.z * a.z) * (b.x * b.x + b.z * b.z)));
                return result;
            }

            return 0f;
        }
        public static float CalculateAngle180OnY(Vector3 a, Vector3 b, Vector3 origin)
        {
            if (a != b)
            {
                a -= origin;
                b -= origin;
                if (a != b)
                {
                    float result = Mathf.Rad2Deg * Mathf.Acos((a.x * b.x + a.z * b.z) / Mathf.Sqrt((a.x * a.x + a.z * a.z) * (b.x * b.x + b.z * b.z)));
                    return result;
                }
            }
            return float.NaN;
        }
        public static float CalculateAngle360OnZ(Vector3 a, Vector3 b)
        {
            if (a != b)
            {
                float result = Mathf.Rad2Deg * Mathf.Acos((a.x * b.x + a.y * b.y) / Mathf.Sqrt((a.x * a.x + a.y * a.y) * (b.x * b.x + b.y * b.y)));
                if (b.y < a.y)
                {
                    result += 180;
                }
                return result;
            }

            return float.NaN;
        }
        public static float CalculateAngle360OnZ(Vector3 a, Vector3 b, Vector3 origin)
        {
            if (a != b)
            {
                a -= origin;
                b -= origin;
                float result = Mathf.Rad2Deg * Mathf.Acos((a.x * b.x + a.y * b.y) / Mathf.Sqrt((a.x * a.x + a.y * a.y) * (b.x * b.x + b.y * b.y)));
                if (b.y < a.y)
                {
                    result += 180;
                }
                return result;
            }
            return float.NaN;
        }
        public static float CalculateAngle180OnZ(Vector3 a, Vector3 b)
        {
            if (a != b)
            {
                float result = Mathf.Rad2Deg * Mathf.Acos((a.x * b.x + a.y * b.y) / Mathf.Sqrt((a.x * a.x + a.y * a.y) * (b.x * b.x + b.y * b.y)));
                return result;
            }

            return 0f;
        }
        public static float CalculateAngle180OnZ(Vector3 a, Vector3 b, Vector3 origin)
        {
            if (a != b)
            {
                a -= origin;
                b -= origin;
                if (a != b)
                {
                    float result = Mathf.Rad2Deg * Mathf.Acos((a.x * b.x + a.y * b.y) / Mathf.Sqrt((a.x * a.x + a.y * a.y) * (b.x * b.x + b.y * b.y)));
                    return result;
                }
            }
            return float.NaN;
        }
        public static float ReturnSnappedFloat(float source, float snapValue)
        {
            return (int)(source / snapValue) * snapValue;
        }
        public static bool CheckRange(float number, float min, float max)
        {
            if (number < max && number > min) return true;
            return false;
        }
        public static bool CheckAngle360(float angle, float min, float max)
        {
            if (angle < max && angle > min) return true;
            return false;
        }
        public static bool CheckRange180(float angle, float treshold)
        {
            if (angle > treshold) return true;
            return false;
        }
        public static bool CheckRange180(float angle, float treshold, float tolerance)
        {
            if (angle > treshold ^ angle < tolerance) return true;
            return false;
        }
        public static bool CheckRange360(Vector3 a, Vector3 b, float min, float max)
        {
            float angle = CalculateAngle360OnY(a, b);
            return CheckAngle360(angle, min, max);
        }
        public static bool CheckRange180(Vector3 a, Vector3 b, float treshold)
        {
            float angle = CalculateAngle180OnY(a, b);
            return CheckRange180(angle, treshold);
        }
        public static bool CheckType(object object1, object object2)
        {
            return object1.GetType() == object2.GetType();
        }
        public static bool CheckType(System.Type type1, System.Type type2)
        {
            return type1 == type2;
        }
        public static Color GetRandomColor()
        {
            return UnityRandom.ColorHSV();
        }
        public static Color GetRandomColor(int rMin, int rMax, int gMin, int gMax, int bMin, int bMax)
        {
            float r = (float)UnityRandom.Range(rMin, rMax) / 255;
            float g = (float)UnityRandom.Range(gMin, gMax) / 255;
            float b = (float)UnityRandom.Range(bMin, bMax) / 255;
            return new Color(r, g, b);
        }
        public static Color GetRandomColor(Color refrenceColor, int rTol, int gTol, int bTol)
        {
            float r = refrenceColor.r, g = refrenceColor.g, b = refrenceColor.b;
            float rTol0 = (float)rTol / 255;
            float gTol0 = (float)gTol / 255;
            float bTol0 = (float)bTol / 255;

            r = UnityRandom.Range(r - rTol0, r + rTol0);
            g = UnityRandom.Range(g - gTol0, g + gTol0);
            b = UnityRandom.Range(b - bTol0, b + bTol0);

            return new Color(r, g, b);
        }
        public static Color GetRandomColor(Color refrenceColor, float rTol, float gTol, float bTol)
        {
            float r = refrenceColor.r, g = refrenceColor.g, b = refrenceColor.b;
            rTol /= 255;
            gTol /= 255;
            bTol /= 255;

            r = UnityRandom.Range(r - rTol, r + rTol);
            g = UnityRandom.Range(g - gTol, g + gTol);
            b = UnityRandom.Range(b - bTol, b + bTol);

            return new Color(r, g, b);
        }
        public static Color GetRandomColorBetween2Color(Color a, Color b)
        {
            return Color.Lerp(a, b, UnityRandom.Range(0, 1));
        }
        public static object GetARandomObject(System.Array array)
        {
            int index = UnityRandom.Range(0, array.Length);
            return array.GetValue(index);
        }
        public static object[] GetRandomObjectAsArray(System.Array array, int count)
        {
            object[] result = new object[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = array.GetValue((int)UnityRandom.value % array.Length);
            }
            return result;
        }
        public static List<object> GetRandomObjectAsList(System.Array array, int count)
        {
            List<object> result = new List<object>();
            for (int i = 0; i < count; i++)
            {
                result.Add(array.GetValue((int)UnityRandom.value % array.Length));
            }
            return result;
        }
        public static object GetARandomObject(List<object> list)
        {
            int index = UnityRandom.Range(0, list.Count);
            return list[index];
        }
        public static object GetARandomObject(IList<object> list)
        {
            int index = UnityRandom.Range(0, list.Count);
            return list[index];
        }
        public static List<T> GetNewListFromList<T>(IList list)
        {
            List<T> result = new List<T>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is T)
                {
                    result.Add((T)list[i]);
                }
            }
            return result;
        }
    }
    namespace Text 
    {
        public static partial class UtilitiesIfTahsin
        {
            public static string FormatName(string original) 
            {
                List<char> temp0 = new List<char>();
                List<string> temp1 = new List<string>();
                for(int i = 0; i < original.Length; i++) 
                {
                    temp0.Add(original[i]);
                    if (i == original.Length - 1 || i + 1 < original.Length && char.IsUpper(original[i + 1])) 
                    {
                        temp1.Add(new string(temp0.ToArray()));
                        temp0.Clear();
                        if (i > 0) temp1.Add(" ");
                    }
                }
                string result = null;
                foreach(string s in temp1) 
                {
                    result += s;
                }
                return result;
            }
            public static string[] DivideStringAsArray(string original, bool  insertSpaces = false) 
            {
                if (original != null)
                {
                    List<string> temp = new List<string>();
                    int first = 0, last = 0;
                    for(int i = 0; i < original.Length - 1 ; i++,last++) 
                    {
                        if (char.IsUpper(original[i + 1])) 
                        {
                            temp.Add(original.Substring(first,last));
                            if (insertSpaces) 
                            {
                                temp.Add(" ");
                            }
                            first = i;
                        }
                    }
                    return temp.ToArray();
                }
                else return null;

            }
        }
    }
    namespace CustomValueTypes
    {
        [System.Serializable]
        public struct IntInterval
        {
            public int min;
            public int max;

            public bool isMinCounting;
            public bool isMaxCounting;

            public IntInterval(int min, int max, bool isMinCounting, bool isMaxCounting)
            {
                this.min = this.max = 0;
                if (max > min)
                {
                    this.min = min;
                    this.max = max;
                }
                else if (min > max)
                {
                    this.max = min;
                    this.min = max;
                }
                this.isMinCounting = isMinCounting;
                this.isMaxCounting = isMaxCounting;
            }

            public override string ToString()
            {
                return $"IntInterval:{min},{isMinCounting};{max},{isMaxCounting}";
            }

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public int GetRandom() 
            {
                return UnityRandom.Range(min,max);
            }

            public static bool operator ==(int number, IntInterval interval)
            {
                if (number < interval.max && number > interval.min)
                {
                    return true;
                }
                else if (interval.isMaxCounting && interval.max == number)
                {
                    return true;
                }
                else if (interval.isMinCounting && interval.min == number)
                {
                    return true;
                }
                else return false;
            }
            public static bool operator !=(int number, IntInterval interval)
            {
                if (number < interval.min || number > interval.max)
                {
                    return true;
                }
                else if (!interval.isMaxCounting && interval.max == number)
                {
                    return true;
                }
                else if (!interval.isMinCounting && interval.max == number)
                {
                    return true;
                }
                else return false;
            }
            public static IntInterval operator +(int a, IntInterval interval)
            {
                return new IntInterval(interval.min + a, interval.max + a, interval.isMinCounting, interval.isMaxCounting);
            }
            public static IntInterval operator -(int a, IntInterval interval) 
            {
                return new IntInterval(interval.min - a, interval.max - a, interval.isMinCounting, interval.isMaxCounting);
            }
            public static IntInterval operator +(IntInterval interval, int a)
            {
                return new IntInterval(interval.min + a, interval.max + a, interval.isMinCounting, interval.isMaxCounting);
            }
            public static IntInterval operator -(IntInterval interval, int a)
            {
                return new IntInterval(interval.min - a, interval.max - a, interval.isMinCounting, interval.isMaxCounting);
            }
            public static IntInterval operator *(IntInterval interval ,int a)
            {
                return new IntInterval(interval.min * a, interval.max * a, interval.isMinCounting, interval.isMaxCounting);
            }
            public static IntInterval operator /(IntInterval interval, int a)
            {
                return new IntInterval(interval.min / a, interval.max / a, interval.isMinCounting, interval.isMaxCounting);
            }
        }
        [System.Serializable]
        public struct FloatInterval
        {
            public float min;
            public float max;

            public bool isMinCounting;
            public bool isMaxCounting;

            public FloatInterval(float min, float max, bool isMinCounting, bool isMaxCounting)
            {
                this.min = this.max = 0;
                if (max > min)
                {
                    this.min = min;
                    this.max = max;
                }
                else if (min > max)
                {
                    this.max = min;
                    this.min = max;
                }
                this.isMinCounting = isMinCounting;
                this.isMaxCounting = isMaxCounting;
            }

            public override string ToString()
            {
                string min = isMinCounting ? "[" : "(";
                string max = isMaxCounting ? "]" : ")";
                return $"FloatInterval:{min},{this.min};{this.max},{max}";
            }

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
            public float GetRandom() 
            {
                return UnityRandom.Range(min,max);
            }
            public static bool operator ==(float number, FloatInterval interval)
            {
                if (number < interval.max && number > interval.min)
                {
                    return true;
                }
                else if (interval.isMaxCounting && interval.max == number)
                {
                    return true;
                }
                else if (interval.isMinCounting && interval.min == number)
                {
                    return true;
                }
                else return false;
            }
            public static bool operator ==(FloatInterval a,FloatInterval b) 
            {
                return a.isMaxCounting == b.isMaxCounting &&
                    a.isMinCounting == b.isMinCounting &&
                    a.max == b.max && a.min == b.min;
            }
            public static bool operator !=(FloatInterval a, FloatInterval b)
            {
                if (a.min != b.min) return false;
                else if (a.max != b.max) return false;
                else if (a.isMaxCounting != b.isMaxCounting) return false;
                else if (a.isMinCounting != b.isMinCounting) return false;
                else return true;
            }
            public static bool operator !=(float number, FloatInterval interval)
            {
                if (number < interval.min || number > interval.max)
                {
                    return true;
                }
                else if (!interval.isMaxCounting && interval.max == number)
                {
                    return true;
                }
                else if (!interval.isMinCounting && interval.max == number)
                {
                    return true;
                }
                else return false;
            }
            public static FloatInterval operator +(float a, FloatInterval interval)
            {
                return new FloatInterval(interval.min + a, interval.max + a, interval.isMinCounting, interval.isMaxCounting);
            }
            public static FloatInterval operator -(float a, FloatInterval interval)
            {
                return new FloatInterval(interval.min - a, interval.max - a, interval.isMinCounting, interval.isMaxCounting);
            }
            public static FloatInterval operator +(FloatInterval interval, float a)
            {
                return new FloatInterval(interval.min + a, interval.max + a, interval.isMinCounting, interval.isMaxCounting);
            }
            public static FloatInterval operator -(FloatInterval interval, float a)
            {
                return new FloatInterval(interval.min - a, interval.max - a, interval.isMinCounting, interval.isMaxCounting);
            }
            public static FloatInterval operator *(FloatInterval interval, float a)
            {
                return new FloatInterval(interval.min * a, interval.max * a, interval.isMinCounting, interval.isMaxCounting);
            }
            public static FloatInterval operator /(FloatInterval interval, float a)
            {
                return new FloatInterval(interval.min / a, interval.max / a, interval.isMinCounting, interval.isMaxCounting);
            }
        }
    }
    namespace Collections
    {
        namespace Failed
        {
            [System.Serializable]
            public class ExclusiveList<T> : ICollection<T>, IEnumerable<T>, IList<T> where T : class
            {
                [SerializeReference]
                public List<T> innerList = new List<T>();

                public T this[int index]
                {
                    get => innerList[index];
                    set
                    {
                        if (!innerList.Contains(value)) innerList[index] = value;
                    }
                }

                public int Count => innerList.Count;
                public bool IsReadOnly => false;

                public void Add(T item)
                {
                    if (!innerList.Contains(item)) innerList.Add(item);
                    else throw new System.Exception("Item already exist.");
                }
                public void AddWithoutException(T item)
                {
                    if (!innerList.Contains(item)) innerList.Add(item);
                }
                public void Clear()
                {
                    innerList.Clear();
                }
                public bool Contains(T item)
                {
                    return innerList.Contains(item);
                }
                public void CopyTo(T[] array, int arrayIndex)
                {
                    innerList.CopyTo(array, arrayIndex);
                }
                public void CopyToList(ref List<T> list)
                {
                    foreach (T t in this)
                    {
                        list.Add(t);
                    }
                }
                public void CopyToXList(ref ExclusiveList<T> xList)
                {
                    foreach (T t in this)
                    {
                        xList.AddWithoutException(t);
                    }
                }
                public IEnumerator<T> GetEnumerator()
                {
                    return innerList.GetEnumerator();
                }
                public int IndexOf(T item)
                {
                    for (int i = 0; i < innerList.Count; i++)
                    {
                        if (innerList[i] == item)
                        {
                            return i;
                        }
                    }
                    throw new System.Exception("No item found.");
                }
                public void Insert(int index, T item)
                {
                    if (index >= innerList.Count) throw new System.Exception("Index out of range.");
                    else if (index < 0) throw new System.Exception("Index can't be negative.");
                    else
                    {
                        if (!innerList.Contains(item)) innerList[index] = item;
                        else throw new System.Exception("Item already exist.");
                    }
                }
                public void InsertWithoutException(int index, T item)
                {
                    if (index >= 0 && index < Count && !innerList.Contains(item)) innerList[index] = item;
                }
                public bool Remove(T item)
                {
                    if (innerList.Contains(item))
                    {
                        innerList.Remove(item);
                        return true;
                    }
                    else return false;
                }
                public void RemoveAt(int index)
                {
                    if (index >= innerList.Count) throw new System.Exception("Index out of range.");
                    else if (index < 0) throw new System.Exception("Index can't be negative.");
                    else innerList.RemoveAt(index);
                }
                public void RemoveAtWithoutException(int index)
                {
                    if (index < Count && index >= 0) innerList.RemoveAt(index);
                }
                public List<T> ReturnList()
                {
                    List<T> list = new List<T>();
                    foreach (T t in this)
                    {
                        list.Add(t);
                    }
                    return list;
                }
                public System.Type GetListType()
                {
                    return typeof(T);
                }
                public int GetTypeAmount(System.Type type)
                {
                    int amount = 0;
                    foreach (T t in innerList)
                    {
                        if (type == t.GetType()) amount++;
                    }
                    return amount;
                }
                IEnumerator IEnumerable.GetEnumerator()
                {
                    return innerList.GetEnumerator();
                }
            }
            public class SupriseBox<T> : ICollection<T>, IEnumerable<T> where T : class
            {
                public List<T> innerList = new List<T>();
                public List<int> rates = new List<int>();


                public T this[int index]
                {
                    private get
                    {
                        return innerList[index];
                    }
                    set
                    {
                        innerList[index] = value;
                    }
                }
                public int this[T item]
                {
                    get
                    {
                        for (int i = 0; i < innerList.Count; i++)
                        {
                            if (item == innerList[i]) return i;
                        }
                        throw new System.Exception("Item not in box.");
                    }
                }

                public int Count => innerList.Count;
                public bool IsReadOnly => false;
                public int totalChanceAmount
                {
                    get
                    {
                        int amount = 0;
                        foreach (int i in rates)
                        {
                            amount += i;
                        }
                        return amount;
                    }
                }

                public void Add(T item)
                {
                    Debug.Log(item.ToString());
                    if (!innerList.Contains(item))
                    {
                        innerList.Add(item);
                        rates.Add(1);
                    }
                    else throw new System.Exception("Item already exist.");
                }
                public void Add(T item, int chance)
                {
                    if (!innerList.Contains(item))
                    {
                        innerList.Add(item);
                        rates.Add(chance);
                    }
                    else throw new System.Exception("Item already exist.");
                }
                public void AddWithoutException(T item)
                {
                    if (!innerList.Contains(item))
                    {
                        innerList.Add(item);
                        rates.Add(1);
                    }
                }
                public void AddWithoutException(T item, int rate)
                {
                    if (!innerList.Contains(item))
                    {
                        innerList.Add(item);
                        rates.Add(rate);
                    }
                }
                public void Clear()
                {
                    innerList.Clear();
                    rates.Clear();
                }
                public bool Contains(T item)
                {
                    return innerList.Contains(item);
                }
                public void ChangeRateOfItem(int index, int newRate)
                {
                    rates[index] = newRate;
                }
                public void ChangeRateOfItem(T item, int newRate)
                {
                    int index = this[item];
                    rates[index] = newRate;
                }
                public void CopyTo(T[] array, int arrayIndex)
                {
                    innerList.CopyTo(array, arrayIndex);
                }
                public IEnumerator<T> GetEnumerator()
                {
                    return innerList.GetEnumerator();
                }
                public bool Remove(T item)
                {

                    if (innerList.Contains(item))
                    {
                        int index = this[item];
                        innerList.Remove(item);
                        rates.RemoveAt(index);
                        return true;
                    }
                    else return false;
                }
                public string GetStringOfItem(int index)
                {
                    return innerList[index].GetType().ToString() + ":" + innerList[index].ToString();
                }
                public T GetSuprised()
                {
                    int suprise = UnityRandom.Range(0, totalChanceAmount);

                    return null;
                }
                IEnumerator IEnumerable.GetEnumerator()
                {
                    return innerList.GetEnumerator();
                }
            }
        }
    }
}
